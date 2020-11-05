using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using BlazorAppClient.Server.Models;
using BlazorAppClient.Shared;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace BlazorAppClient.Controllers
{
    [Route("_Auth")]
    public class AuthController : Controller
    {
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly UserManager<IdentityUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        dbContext db = new dbContext();

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            db.Dispose();
        }


        public AuthController(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        /// <summary>
        /// add admin user incase non exists
        /// </summary>
        private async Task seedDb()
        {
            try
            {
                var admin_user = db.AspNetUsers.Where(i => i.Email == "ben@cha.com").FirstOrDefault();
                if (admin_user == null)
                {
                    var new_admin_user = new IdentityUser();
                    new_admin_user.Email = "ben@cha.com";
                    new_admin_user.UserName = new_admin_user.Email;
                    await userManager.CreateAsync(new_admin_user, "Password#99");//create user

                    bool x = await roleManager.RoleExistsAsync("student");
                    if (!x)
                    {
                        var role = new IdentityRole("student");
                        await roleManager.CreateAsync(role);
                    }
                    await userManager.AddToRoleAsync(new_admin_user, "student");//add user to admin role
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }


        [HttpPost("Login")]
        public async Task<JsonResult> Login(string email, string password)
        {
            //await seedDb();
            var result = await signInManager.PasswordSignInAsync(email, password, false, false);
            if (result.Succeeded)
            {
               //
                var asp_net_user = db.AspNetUsers
                    .Where(i => i.Email == email)
                    .Include(i=>i.MCompanyIdFkNavigation)
                    .FirstOrDefault();
                //
                var company = db.MCompany.Find(asp_net_user.MCompanyIdFk);
                var user = new CurrentUser();
                user.user_id = asp_net_user.Id;
                user.company_id = asp_net_user.MCompanyIdFk;
                user.company_name = asp_net_user.MCompanyIdFkNavigation.CompanyName;
                //key 
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Globals.Secret));
                var signingCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                //claims
                var claims = new List<Claim>();
                claims.Add(new Claim("user_id", asp_net_user.Id));
                claims.Add(new Claim("company_id", asp_net_user.MCompanyIdFk));
                var roles = db.AspNetRoles.Select(i => i.Name).ToList();
                var id_user = await userManager.FindByNameAsync(asp_net_user.Email);
                //add roles to claims
                foreach(var role in roles)
                {
                    if(await userManager.IsInRoleAsync(id_user,role))
                    {
                        claims.Add(new Claim(ClaimTypes.Role,role));
                    }
                }
                //create jwt token
                var token = new JwtSecurityToken(
                    Globals.Issuer,
                    Globals.Audience,
                    claims,
                    DateTime.Now,
                    DateTime.Now.AddYears(1),//one year token
                    signingCredentials
                    );
                //serialize token
                var jsonToken = new JwtSecurityTokenHandler().WriteToken(token);
                return Json(new{
                    res="ok",
                    data=user,
                    access_token=jsonToken
                });
            }
            else
            {
                return Json(new
                {
                    res = "err",
                    data = "Invalid Credentials"
                });
            }
        }

        [HttpPost]
        [Route("LogOff")]
        public async Task<ActionResult> LogOff()
        {
            await signInManager.SignOutAsync();
            return Ok("Logout Success");
        }


    }
}

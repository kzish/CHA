using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Models;
using Admin.Models.Admin;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Admin.Controllers
{

    [Route("Company")]
    [Authorize(Roles = "system_admin")]
    public class CompanyController : Controller
    {
        private dbContext db = new dbContext();

        private readonly UserManager<IdentityUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public CompanyController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
        }


        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            db.Dispose();
        }

        [HttpGet("AllCompanies")]
        [HttpGet("")]
        public IActionResult AllCompanies()
        {
            ViewBag.title = "All Companies";
            return View();
        }

        [HttpGet("ajaxAllCompanies")]
        public IActionResult ajaxAllCompanies()
        {
            var companies = db.MCompany.ToList();
            ViewBag.companies = companies;
            return View();
        }

        [HttpGet("CreateNewCompany")]
        public IActionResult CreateNewCompany()
        {
            ViewBag.title = "Create Company";
            return View();
        }

        [HttpPost("CreateNewCompany")]
        public IActionResult CreateNewCompany(MCompany company)
        {
            ViewBag.title = "Create Company";
            try
            {
                db.MCompany.Add(company);
                db.SaveChanges();
                TempData["msg"] = "Company Saved";
                TempData["type"] = "success";
                return RedirectToAction("AllCompanies");
            }
            catch (Exception ex)
            {
                TempData["msg"] = ex.Message;
                TempData["type"] = "error";
            }
            return View();
        }


        [HttpPost("DeleteCompany")]
        public IActionResult DeleteCompany(string id)
        {
            try
            {
                var company = db.MCompany.Find(id);
                db.MCompany.Remove(company);
                db.SaveChanges();
                TempData["msg"] = "Company Deleted";
                TempData["type"] = "success";
            }
            catch (Exception ex)
            {
                TempData["msg"] = ex.Message;
                TempData["type"] = "error";
            }
            return RedirectToAction("AllCompanies");
        }

        [HttpGet("EditCompany")]
        public IActionResult EditCompany(string company_id)
        {
            ViewBag.title = "Edit Company";
            var company = db.MCompany.Find(company_id);
            ViewBag.company = company;
            return View();
        }

        [HttpPost("EditCompany")]
        public IActionResult EditCompany(MCompany company)
        {
            try
            {
                db.Entry(company).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
                TempData["msg"] = "Company Updated";
                TempData["type"] = "success";
                return RedirectToAction("AllCompanies");
            }
            catch (Exception ex)
            {
                TempData["msg"] = ex.Message;
                TempData["type"] = "error";
            }
            return View();
        }


        //[HttpGet("Users")]
        [Route("AllUsers")]
        public IActionResult AllUsers(string company_id)
        {
            var company = db.MCompany.Find(company_id);
            ViewBag.title = $"All Users - {company.CompanyName}";
            ViewBag.company = company;
            return View();
        }

        [HttpGet("ajaxAllUsers")]
        public IActionResult ajaxAllUsers(string company_id)
        {
            var company = db.MCompany.Find(company_id);
            var users = db.AspNetUsers
                .Where(i => i.MCompanyIdFk == company_id)
                .ToList();
            ViewBag.users = users;
            ViewBag.company = company;
            return View();
        }



        [HttpGet("CreateNewUser")]
        public IActionResult CreateNewUser(string company_id)
        {
            var company = db.MCompany.Find(company_id);
            ViewBag.title = $"New User -  {company.CompanyName}";
            ViewBag.company = company;
            return View();
        }

        [HttpPost("CreateNewUser")]
        public async Task<IActionResult> CreateNewUser(string company_id, string Email, String Password, bool company_admin, bool student)
        {
            try
            {
                var company = db.MCompany.Find(company_id);
                //
                var id_user_exist = db.AspNetUsers.Where(i => i.Email == Email).Any();
                if (id_user_exist)
                {
                    TempData["msg"] = "Email is already taken";
                    TempData["type"] = "error";
                    return RedirectToAction("CreateNewUser", new { company_id = company.Id });
                }
                else
                {
                    //
                    var new_id_user = new IdentityUser()
                    {
                        Email = Email,
                        UserName = Email
                    };
                    //
                    await userManager.CreateAsync(new_id_user, Password);
                    //
                    var asp_net_user = db.AspNetUsers.Where(i => i.Email == Email).FirstOrDefault();
                    asp_net_user.MCompanyIdFk = company_id;
                    db.SaveChanges();
                    //
                    if (!await roleManager.RoleExistsAsync("company_admin")) await roleManager.CreateAsync(new IdentityRole("company_admin"));
                    if (!await roleManager.RoleExistsAsync("student")) await roleManager.CreateAsync(new IdentityRole("student"));
                    //
                    if (company_admin) await userManager.AddToRoleAsync(new_id_user, "company_admin");
                    if (student) await userManager.AddToRoleAsync(new_id_user, "student");
                    //
                    TempData["msg"] = "User created";
                    TempData["type"] = "success";
                    //
                    return RedirectToAction("AllUsers", new { company_id });
                }


            }
            catch (Exception ex)
            {
                TempData["msg"] = ex.Message;
                TempData["type"] = "error";
                return RedirectToAction("CreateNewUser", new { company_id });
            }
        }

        [HttpPost("DeleteUser")]
        public ActionResult DeleteUser(string user_id, string company_id)
        {
            try
            {
                var asp_net_user = db.AspNetUsers.Find(user_id);
                db.AspNetUsers.Remove(asp_net_user);
                db.SaveChanges();
                TempData["msg"] = "User Deleted";
                TempData["type"] = "success";
                return RedirectToAction("AllUsers", new { company_id });
            }
            catch (Exception ex)
            {
                TempData["msg"] = ex.Message;
                TempData["type"] = "error";
                return RedirectToAction("AllUsers", new { company_id });
            }
        }


        [HttpGet("EditUser")]
        public async Task<IActionResult> EditUser(string user_id,string company_id)
        {
            var id_user = await userManager.FindByIdAsync(user_id);

            ViewBag.title = "Edit User";
            var user = db.AspNetUsers.Find(user_id);
            ViewBag.user = user;
            var roles = new Roles();
            roles.company_admin = await userManager.IsInRoleAsync(id_user, "company_admin");
            roles.student = await userManager.IsInRoleAsync(id_user, "student");
            ViewBag.roles = roles;
            ViewBag.company = db.MCompany.Find(company_id);
            return View();
        }

        [HttpPost("EditUser")]
        public async Task<IActionResult> EditUser(string company_id,string user_id, bool reset_password, bool company_admin, bool student)
        {
            try
            {
                var id_user = await userManager.FindByIdAsync(user_id);

                if(reset_password)
                {
                    var token = await userManager.GeneratePasswordResetTokenAsync(id_user);
                    await userManager.ResetPasswordAsync(id_user, token, "Password#99");
                }
                if (company_admin)
                {
                    if (!await userManager.IsInRoleAsync(id_user, "company_admin"))
                        await userManager.AddToRoleAsync(id_user, "company_admin");
                }
                else if(!company_admin)
                {
                    if (await userManager.IsInRoleAsync(id_user, "company_admin"))
                        await userManager.RemoveFromRoleAsync(id_user, "company_admin");
                }
                if (student)
                {
                    if (!await userManager.IsInRoleAsync(id_user, "student"))
                        await userManager.AddToRoleAsync(id_user, "student");
                }
                else if (!student)
                {
                    if (await userManager.IsInRoleAsync(id_user, "student"))
                        await userManager.RemoveFromRoleAsync(id_user, "student");
                }
                TempData["msg"] = "User Updated";
                TempData["type"] = "success";
                return RedirectToAction("AllUsers", new { company_id });
            }
            catch (Exception ex)
            {
                TempData["msg"] = ex.Message;
                TempData["type"] = "error";

                ViewBag.user = db.AspNetUsers.Find(user_id);
                return RedirectToAction("EditUser", new { user_id,company_id});
            }

        }


    }
}

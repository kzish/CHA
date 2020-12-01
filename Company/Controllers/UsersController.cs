using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Company.Models;
using Company.Models.Admin;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Company.Controllers
{
    [Route("Users")]
    public class UsersController : Controller
    {
        private dbContext db = new dbContext();

        private readonly UserManager<IdentityUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;


        public UsersController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
        }


        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            db.Dispose();
        }

        //[HttpGet("Users")]
        [Route("AllUsers")]
        [Route("")]
        public IActionResult AllUsers()
        {
            var asp_net_user = db.AspNetUsers
                .Include(i => i.MCompanyIdFkNavigation)
                .Where(i => i.Email == User.Identity.Name).FirstOrDefault();
            ViewBag.title = $"All Users - {asp_net_user.MCompanyIdFkNavigation.CompanyName}";
            ViewBag.user = asp_net_user;
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
            ViewBag.title = $"New User";
            ViewBag.company = company;
            return View();
        }

        [HttpPost("CreateNewUser")]
        public async Task<IActionResult> CreateNewUser(string Email, String Password, bool company_admin, bool student)
        {
            //current user
            var current_asp_net_user = db.AspNetUsers
                .Include(i => i.MCompanyIdFkNavigation)
                .Where(i => i.Email == User.Identity.Name)
                .FirstOrDefault();
            try
            {

                //
                var email_exist = db.AspNetUsers.Where(i => i.Email == Email).Any();
                if (email_exist)
                {
                    TempData["msg"] = "Email is already taken";
                    TempData["type"] = "error";
                    return RedirectToAction("CreateNewUser", new { company_id = current_asp_net_user.MCompanyIdFk });
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
                    var result = await userManager.CreateAsync(new_id_user, Password);
                    if(!result.Succeeded)
                    {
                        TempData["msg"] = String.Join(", ",result.Errors.Select(i=>i.Description).ToList());
                        TempData["type"] = "error";
                        return RedirectToAction("CreateNewUser", new { company_id = current_asp_net_user.MCompanyIdFk });
                    }
                    //
                    var new_asp_net_user = db.AspNetUsers.Where(i => i.Email == Email).First();
                    new_asp_net_user.MCompanyIdFk = current_asp_net_user.MCompanyIdFk;
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
                    return RedirectToAction("AllUsers", new { company_id = current_asp_net_user.MCompanyIdFk });
                }


            }
            catch (Exception ex)
            {
                TempData["msg"] = ex.Message;
                TempData["type"] = "error";
                return RedirectToAction("CreateNewUser", new { company_id = current_asp_net_user.MCompanyIdFk });
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
        public async Task<IActionResult> EditUser(string user_id, string company_id)
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
        public async Task<IActionResult> EditUser(string company_id, string user_id, bool reset_password, bool company_admin, bool student)
        {
            try
            {
                var id_user = await userManager.FindByIdAsync(user_id);

                if (reset_password)
                {
                    var token = await userManager.GeneratePasswordResetTokenAsync(id_user);
                    await userManager.ResetPasswordAsync(id_user, token, "Password#99");
                }
                if (company_admin)
                {
                    if (!await userManager.IsInRoleAsync(id_user, "company_admin"))
                        await userManager.AddToRoleAsync(id_user, "company_admin");
                }
                else if (!company_admin)
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
                return RedirectToAction("EditUser", new { user_id, company_id });
            }

        }


        /// <summary>
        /// courses for a specific user
        /// </summary>
        /// <param name="user_id"></param>
        /// <returns></returns>
        [HttpGet("Courses")]
        public IActionResult Courses(string user_id, string course_category)
        {
            //
            var user = db.AspNetUsers
                .Include(i=>i.MCourseTakers)//inlude users courses
                .Where(i => i.Id == user_id)
                .FirstOrDefault();
            ViewBag.title = $"Courses for - {user.Email}";
            //
            var course_categories = db.ECourseCategory.ToList();
            List<MCourse> all_courses =null;
            if(string.IsNullOrEmpty(course_category))
            {
                all_courses=db.MCourse
                    .Include(i => i.ECourseCategoryIdFkNavigation)
                    .ToList();
            }
            else
            {
                all_courses = db.MCourse
                    .Where(i => i.ECourseCategoryIdFk == course_category)
                    .Include(i => i.ECourseCategoryIdFkNavigation)
                    .ToList();
            }

               
            //
            ViewBag.course_category = course_category;
            ViewBag.user = user;
            ViewBag.all_courses = all_courses.ToList();
            ViewBag.course_categories = course_categories;
            //
            return View();
        }


        [HttpPost("AddCourse")]
        public IActionResult AddCourse(string course_id, string user_id)
        {
            try
            {
                var course_taker = new MCourseTakers();
                course_taker.CourseIdFk = course_id;
                course_taker.AspNetUserIdFk = user_id;
                db.MCourseTakers.Add(course_taker);
                db.SaveChanges();
                TempData["msg"] = "Course Added";
                TempData["type"] = "success";
            }
            catch (Exception ex)
            {
                TempData["msg"] = ex.StackTrace;
                TempData["type"] = "error";
            }
            return RedirectToAction("Courses", new { user_id });
        }

        [HttpPost("RemoveCourse")]
        public IActionResult RemoveCourse(string course_id, string user_id)
        {
            try
            {
                var course_taker = db.MCourseTakers
                    .Where(i=>i.CourseIdFk==course_id && i.AspNetUserIdFk==user_id)
                    .FirstOrDefault();
                db.MCourseTakers.Remove(course_taker);
                db.SaveChanges();
                TempData["msg"] = "Course Removed";
                TempData["type"] = "success";
            }
            catch (Exception ex)
            {
                TempData["msg"] = ex.Message;
                TempData["type"] = "error";
            }
            return RedirectToAction("Courses", new { user_id });
        }
    }
}

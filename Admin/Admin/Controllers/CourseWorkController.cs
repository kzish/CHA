using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Models;
using Admin.Models.Admin;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Admin.Controllers
{

    [Route("CourseWork")]
    [Authorize(Roles = "system_admin")]
    public class CourseWorkController : Controller
    {
        private dbContext db = new dbContext();

        private readonly UserManager<IdentityUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public CourseWorkController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
        }


        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            db.Dispose();
        }

        [HttpGet("AllPages")]
        public IActionResult AllPages()
        {
            ViewBag.title = "All Pages";
            return View();
        }

        [HttpGet("ajaxAllPages")]
        public IActionResult ajaxAllPages()
        {
            var courses = db.MCourse
                .Include(i => i.ECourseCategoryIdFkNavigation)
                .ToList();
            ViewBag.courses = courses;
            return View();
        }

        [HttpGet("AllCourseCategories")]
        public IActionResult AllCourseCategories()
        {
            ViewBag.title = "All Course Categories";
            return View();
        }

        [HttpGet("ajaxAllCourseCategories")]
        public IActionResult ajaxAllCourseCategories()
        {
            var course_categories = db.ECourseCategory.ToList();
            ViewBag.course_categories = course_categories;
            return View();
        }

        [HttpGet("CreateNewCourse")]
        public IActionResult CreateNewCourse()
        {
            ViewBag.title = "Create Course";
            var course_categories = db.ECourseCategory.ToList();
            ViewBag.course_categories = course_categories;
            return View();
        }

        [HttpPost("CreateNewCourse")]
        public IActionResult CreateNewCourse(MCourse course)
        {
            var asp_net_user = db.AspNetUsers.Where(i => i.Email == User.Identity.Name).FirstOrDefault();
            ViewBag.title = "Create Course";
            course.DateCreated = DateTime.Now;
            if (course.Published) course.DatePublished = DateTime.Now;
            try
            {
                db.MCourse.Add(course);
                db.SaveChanges();
                TempData["msg"] = "Course Saved";
                TempData["type"] = "success";
                return RedirectToAction("AllCourses");
            }
            catch (Exception ex)
            {
                TempData["msg"] = ex.Message;
                TempData["type"] = "error";
                return RedirectToAction("CreateNewCourse");
            }
        }

        [HttpGet("CreateNewCourseCategory")]
        public IActionResult CreateNewCourseCategory()
        {
            ViewBag.title = "Create Course Category";
            return View();
        }

        [HttpPost("CreateNewCourseCategory")]
        public IActionResult CreateNewCourseCategory(ECourseCategory Coursecategory)
        {
            ViewBag.title = "Create Course Category";
            try
            {
                db.ECourseCategory.Add(Coursecategory);
                db.SaveChanges();
                TempData["msg"] = "Course Saved";
                TempData["type"] = "success";
                return RedirectToAction("AllCourseCategories");
            }
            catch (Exception ex)
            {
                TempData["msg"] = ex.Message;
                TempData["type"] = "error";
                return View();
            }

        }


        [HttpPost("DeleteCourse")]
        public IActionResult DeleteCourse(string id)
        {
            try
            {
                var course = db.MCourse.Find(id);
                db.MCourse.Remove(course);
                db.SaveChanges();
                TempData["msg"] = "Course Deleted";
                TempData["type"] = "success";
            }
            catch (Exception ex)
            {
                TempData["msg"] = ex.Message;
                TempData["type"] = "error";
            }
            return RedirectToAction("AllCourses");
        }


        [HttpPost("DeleteCourseCategory")]
        public IActionResult DeleteCourseCategory(string id)
        {
            try
            {
                var category = db.ECourseCategory.Find(id);
                db.ECourseCategory.Remove(category);
                db.SaveChanges();
                TempData["msg"] = "Category Deleted";
                TempData["type"] = "success";
            }
            catch (Exception ex)
            {
                TempData["msg"] = ex.Message;
                TempData["type"] = "error";
            }
            return RedirectToAction("AllCourseCategories");
        }

        [HttpGet("EditCourse")]
        public IActionResult EditCourse(string course_id)
        {
            ViewBag.title = "Edit Course";
            var course = db.MCourse.Find(course_id);
            ViewBag.course = course;
            var course_categories = db.ECourseCategory.ToList();
            ViewBag.course_categories = course_categories;
            return View();
        }

        [HttpGet("EditCourseCategory")]
        public IActionResult EditCourseCategory(string category_id)
        {
            ViewBag.title = "Edit Category";
            var course_category = db.ECourseCategory.Find(category_id);
            ViewBag.course_category = course_category;
            return View();
        }

        [HttpPost("EditCourse")]
        public IActionResult EditCourse(MCourse course)
        {
            try
            {
                var old_course = db.MCourse.Find(course.Id);
                old_course.CourseName = course.CourseName;
                old_course.Published = course.Published;
                old_course.ECourseCategoryIdFk = course.ECourseCategoryIdFk;
                if (course.Published) old_course.DatePublished = DateTime.Now;
                else old_course.DatePublished = null;
                db.SaveChanges();
                TempData["msg"] = "Course Updated";
                TempData["type"] = "success";
                return RedirectToAction("AllCourses");
            }
            catch (Exception ex)
            {
                TempData["msg"] = ex.Message;
                TempData["type"] = "error";
                return RedirectToAction("EditCourse", new { course_id = course.Id });
            }
        }

        [HttpPost("EditCourseCategory")]
        public IActionResult EditCourseCategory(ECourseCategory CourseCategory)
        {
            try
            {
                db.Entry(CourseCategory).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
                TempData["msg"] = "Category Updated";
                TempData["type"] = "success";
                return RedirectToAction("AllCourseCategories");
            }
            catch (Exception ex)
            {
                TempData["msg"] = ex.Message;
                TempData["type"] = "error";
                return RedirectToAction("EditCourseCategory", new { category_id = CourseCategory.Id });
            }
        }




    }
}

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

    [Route("CourseMaterial")]
    [Authorize(Roles = "system_admin")]
    public class CourseMaterialController : Controller
    {
        private dbContext db = new dbContext();

        private readonly UserManager<IdentityUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public CourseMaterialController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
        }


        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            db.Dispose();
        }

        [HttpGet("AllCourseMaterial")]
        public IActionResult AllCourseMaterial(string course_id)
        {
            ViewBag.title = "All Material";
            ViewBag.course = db.MCourse.Find(course_id);
            return View();
        }

        [HttpGet("ajaxAllCourseMaterial")]
        public IActionResult ajaxAllCourseMaterial(string course_id)
        {
            var materials = db.MCourseMaterial
                .Where(i => i.MCourseIdFk == course_id)
                .Include(i => i.MCourseIdFkNavigation)
                .Include(i => i.MCourseTopicIdFkNavigation)
                .Include(i => i.CreatedByAspNetUserIdFkNavigation)
                .ToList();
            ViewBag.materials = materials;
            return View();
        }


        [HttpGet("CreateCourseMaterial")]
        public IActionResult CreateCourseMaterial(string course_id)
        {
            ViewBag.title = "Create Course Material";
            ViewBag.course = db.MCourse.Find(course_id);
            ViewBag.topics = db.MCourseTopic.Where(i=>i.CourseIdFk==course_id).ToList();
            return View();
        }


        [HttpPost("CreateCourseMaterial")]
        public IActionResult CreateCourseMaterial(MCourseMaterial material)
        {
            try
            {
                material.CreatedByAspNetUserIdFk = db.AspNetUsers.Where(i => i.Email == User.Identity.Name).First().Id;
                material.DateCreated = DateTime.Now;
                if (material.Published) material.DatePublished = DateTime.Now;
                db.MCourseMaterial.Add(material);
                db.SaveChanges();
                TempData["msg"] = "Material Created";
                TempData["type"] = "success";
                return RedirectToAction("AllCourseMaterial", new { course_id = material.MCourseIdFk });
            }
            catch (Exception ex)
            {
                TempData["msg"] = ex.Message;
                TempData["type"] = "error";
                return RedirectToAction("CreateCourseMaterial", new { course_id = material.MCourseIdFk });
            }
        }


        [HttpGet("EditCourseMaterial")]
        public IActionResult EditCourseMaterial(string material_id)
        {
            ViewBag.title = "Edit Course Material";

            var material = db.MCourseMaterial
                .Where(i => i.Id == material_id)
                .Include(i => i.MCourseIdFkNavigation)
                .FirstOrDefault();
            ViewBag.material = material;
            ViewBag.topics = db.MCourseTopic.Where(i => i.CourseIdFk == material.MCourseIdFkNavigation.Id).ToList();
            return View();
        }


        [HttpPost("EditCourseMaterial")]
        public IActionResult EditCourseMaterial(MCourseMaterial material)
        {
            var old_material = db.MCourseMaterial.Find(material.Id);
            try
            {
                old_material.MCourseTopicIdFk = material.MCourseTopicIdFk;
                old_material.PageSequence = material.PageSequence;
                old_material.PageData = material.PageData;
                old_material.CreatedByAspNetUserIdFk = db.AspNetUsers.Where(i=>i.Email==User.Identity.Name).FirstOrDefault().Id;
                old_material.DateCreated = DateTime.Now;
                old_material.Published = material.Published;
                old_material.DatePublished = DateTime.Now;
                old_material.PageTitle = material.PageTitle;
                db.SaveChanges();
                TempData["msg"] = "Material Updated";
                TempData["type"] = "success";
                return RedirectToAction("AllCourseMaterial", new
                {
                    course_id = old_material.MCourseIdFk
                });
            }
            catch (Exception ex)
            {
                TempData["msg"] = ex.Message;
                TempData["type"] = "error";
                return RedirectToAction("EditCourseMaterial", new { material_id = old_material.Id });
            }
        }




        [HttpPost("DeleteCourseMaterial")]
        public IActionResult DeleteTopic(string id)
        {
            var material = db.MCourseMaterial.Find(id);
                
            try
            {
                db.MCourseMaterial.Remove(material);
                db.SaveChanges();
                TempData["msg"] = "Material removed";
                TempData["type"] = "success";
            }
            catch (Exception ex)
            {
                TempData["msg"] = ex.Message;
                TempData["type"] = "error";
            }
            return RedirectToAction("AllCourseMaterial", new { course_id = material.MCourseIdFk });

        }




    }
}

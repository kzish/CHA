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

    [Route("CourseTopics")]
    [Authorize(Roles = "system_admin")]
    public class CourseTopicsController : Controller
    {
        private dbContext db = new dbContext();

        private readonly UserManager<IdentityUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public CourseTopicsController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
        }


        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            db.Dispose();
        }

        [HttpGet("AllTopics")]
        public IActionResult AllTopics(string course_id)
        {
            ViewBag.title = "All Topics";
            ViewBag.course = db.MCourse.Find(course_id);
            return View();
        }

        [HttpGet("ajaxAllTopics")]
        public IActionResult ajaxAllTopics(string course_id)
        {
            var topics = db.MCourseTopic
                .Where(i => i.CourseIdFk == course_id)
                .Include(i=>i.CourseIdFkNavigation)
                .ToList();
            ViewBag.topics = topics;
            return View();
        }


        [HttpGet("CreateTopic")]
        public IActionResult CreateTopic(string course_id)
        {
            ViewBag.title = "Create Topic";
            ViewBag.course = db.MCourse.Find(course_id);
            return View();
        }


        [HttpPost("CreateTopic")]
        public IActionResult CreateTopic(string topic_name, string course_id, int sequence)
        {
            try
            {
                var topic = new MCourseTopic();
                topic.CourseIdFk = course_id;
                topic.Topic = topic_name;
                topic.Sequence = sequence;
                db.MCourseTopic.Add(topic);
                db.SaveChanges();
                TempData["msg"] = "Topic Created";
                TempData["type"] = "success";
                return RedirectToAction("AllTopics", new { course_id });
            }
            catch (Exception ex)
            {
                TempData["msg"] = ex.Message;
                TempData["type"] = "error";
                return RedirectToAction("CreateTopic", new { course_id });
            }
        }


        [HttpGet("EditCourseTopic")]
        public IActionResult EditCourseTopic(string course_id, string topic_id)
        {
            ViewBag.title = "Edit Topic";
            ViewBag.course = db.MCourse.Find(course_id);
            ViewBag.topic = db.MCourseTopic.Find(topic_id);
            return View();
        }


        [HttpPost("EditCourseTopic")]
        public IActionResult EditCourseTopic_(string topic_id, string topic_name, int sequence)
        {
            var old_topic = db.MCourseTopic.Find(topic_id);

            try
            {
                old_topic.Topic = topic_name;
                old_topic.Sequence = sequence;
                db.SaveChanges();
                TempData["msg"] = "Topic Updated";
                TempData["type"] = "success";
                return RedirectToAction("AllTopics", new { course_id=old_topic.CourseIdFk });
            }
            catch (Exception ex)
            {
                TempData["msg"] = ex.Message;
                TempData["type"] = "error";
                return RedirectToAction("EditCourseTopic", new { course_id=old_topic.CourseIdFk });
            }
        }




        [HttpPost("DeleteTopic")]
        public IActionResult DeleteTopic(string id)
        {
            var topic = db.MCourseTopic
                .Include(i => i.CourseIdFkNavigation)
                .Where(i => i.Id == id).FirstOrDefault();
            try
            {
                db.MCourseTopic.Remove(topic);
                db.SaveChanges();
                TempData["msg"] = "Topic removed";
                TempData["type"] = "success";
            }
            catch (Exception ex)
            {
                TempData["msg"] = ex.Message;
                TempData["type"] = "error";
            }
            return RedirectToAction("AllTopics", new { course_id = topic.CourseIdFkNavigation.Id });

        }




    }
}

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

    [Route("CourseAssesments")]
    [Authorize(Roles = "system_admin")]
    public class CourseAssesmentsController : Controller
    {
        private dbContext db = new dbContext();

        private readonly UserManager<IdentityUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public CourseAssesmentsController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
        }


        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            db.Dispose();
        }

        [HttpGet("AllAssesments")]
        [HttpGet("")]
        public IActionResult AllAssesments(string course_id)
        {
            ViewBag.title = "All Assesments";
            ViewBag.course = db.MCourse.Find(course_id);
            return View();
        }

        [HttpGet("ajaxAllAssesments")]
        public IActionResult ajaxAllAssesments(string course_id)
        {
            var assesments = db.MContinouseAssesment
                .Where(i => i.MCourseIdFk == course_id)
                .ToList();
            ViewBag.assesments = assesments;
            return View();
        }


        [HttpGet("CreateAssesment")]
        public IActionResult CreateAssesment(string course_id)
        {
            ViewBag.title = "Create Assesment";
            ViewBag.course = db.MCourse.Find(course_id);
            return View();
        }


        [HttpPost("CreateAssesment")]
        public IActionResult CreateAssesment(MContinouseAssesment assesment)
        {
            try
            {
                db.MContinouseAssesment.Add(assesment);
                db.SaveChanges();
                TempData["msg"] = "Assesment Created";
                TempData["type"] = "success";
                return RedirectToAction("AllAssesments", new { course_id = assesment.MCourseIdFk });
            }
            catch (Exception ex)
            {
                TempData["msg"] = ex.Message;
                TempData["type"] = "error";
                return RedirectToAction("CreateAssesment", new { course_id = assesment.MCourseIdFk });
            }
        }


        [HttpGet("EditAssesment")]
        public IActionResult EditAssesment(string assesment_id)
        {
            ViewBag.title = "Edit Assesment";
            var assesment = db.MContinouseAssesment.Find(assesment_id);
            var course = db.MCourse.Find(assesment.MCourseIdFk);
            ViewBag.assesment = assesment;
            ViewBag.course = course;
            return View();
        }


        [HttpPost("EditAssesment")]
        public IActionResult EditAssesment(MContinouseAssesment assesment)
        {
            try
            {
                db.Entry(assesment).State = EntityState.Modified;
                db.SaveChanges();
                TempData["msg"] = "Assesment Updated";
                TempData["type"] = "success";
                return RedirectToAction("AllAssesments", new { course_id = assesment.MCourseIdFk });
            }
            catch (Exception ex)
            {
                TempData["msg"] = ex.Message;
                TempData["type"] = "error";
                return RedirectToAction("EditAssesment", new { course_id = assesment.MCourseIdFk });
            }
        }




        [HttpPost("DeleteAssesment")]
        public IActionResult DeleteAssesment(string id)
        {
            var assesment = db.MContinouseAssesment.Find(id);
            try
            {
                db.MContinouseAssesment.Remove(assesment);
                db.SaveChanges();
                TempData["msg"] = "Assesment removed";
                TempData["type"] = "success";
            }
            catch (Exception ex)
            {
                TempData["msg"] = ex.Message;
                TempData["type"] = "error";
            }
            return RedirectToAction("AllAssesments", new { course_id = assesment.MCourseIdFk });

        }

        [HttpGet("AllCandidates")]
        public IActionResult AllCandidates(string course_id, string assesment_id)
        {
            ViewBag.title = "All Candidates";
            var course = db.MCourse.Find(course_id);
            var assesment = db.MContinouseAssesment.Find(assesment_id);
            ViewBag.course = course;
            ViewBag.assesment = assesment;
            return View();
        }

        [HttpGet("ajaxAllCandidates")]
        public IActionResult ajaxAllCandidates(string assesment_id)
        {
            ViewBag.title = "All Candidates";
            //
            var assesment = db.MContinouseAssesment.Find(assesment_id);

            //
            var candidates = db.MCourseTakers
                .Include(i=>i.AspNetUserIdFkNavigation)
                .Where(i => i.CourseIdFk == assesment.MCourseIdFk)
                .ToList();
            //
            var scores = db.MUsersAssesmentMarks
                .Where(i=>i.MContinouseAssesmentIdFk==assesment_id)
                .ToList();

            ViewBag.scores = scores;
            ViewBag.assesment = assesment;
            ViewBag.candidates = candidates;

            return View();
        }


        [HttpPost("SetCandidatePercentage")]
        public IActionResult SetCandidatePercentage(MUsersAssesmentMarks candidate_assesment, string course_id)
        {
            try
            {
                var existing_score = db.MUsersAssesmentMarks.AsNoTracking().Where(i => i.Id == candidate_assesment.Id).FirstOrDefault();
                if (existing_score == null)
                {
                    //insert score
                    db.MUsersAssesmentMarks.Add(candidate_assesment);
                }
                else
                {
                    db.Entry(candidate_assesment).State = EntityState.Modified;
                }
                db.SaveChanges();
                TempData["msg"] = "Score Saved";
                TempData["type"] = "success";
            }
            catch (Exception ex)
            {
                TempData["msg"] = ex.Message;
                TempData["type"] = "error";
            }
            return RedirectToAction("AllCandidates", new { course_id, assesment_id = candidate_assesment.MContinouseAssesmentIdFk });
        }


    }
}

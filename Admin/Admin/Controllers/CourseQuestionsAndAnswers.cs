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

    [Route("CourseQuestionsAndAnswers")]
    [Authorize(Roles = "system_admin")]
    public class CourseQuestionsAndAnswersController : Controller
    {
        private dbContext db = new dbContext();

        private readonly UserManager<IdentityUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public CourseQuestionsAndAnswersController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
        }


        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            db.Dispose();
        }

        [HttpGet("AllQuestions")]
        public IActionResult AllQuestions(string course_id)
        {
            ViewBag.title = "All Questions";
            var course = db.MCourse.Find(course_id);
            ViewBag.course = course;
            return View();
        }

        [HttpGet("ajaxAllQuestions")]
        public IActionResult ajaxAllQuestions(string course_id)
        {
            var questions = db.MQuestion
                .Include(i => i.MQuestionAnswerOptions)
                .Include(i => i.EQuestionTypeIdFkNavigation)
                .Include(i => i.MCourseTopicIdFkNavigation)
                .Where(i => i.MCourseIdFk == course_id)
                .ToList();
            ViewBag.questions = questions;
            return View();
        }

        [HttpGet("CreateQuestionAndAnswer")]
        public IActionResult CreateQuestionAndAnswer(string question_id,string course_id)
        {
            var course = db.MCourse.Find(course_id);
            //
            var empty_questions = db.MQuestion.Where(i => i.QuestionText == string.Empty).ToList();
            db.MQuestion.RemoveRange(empty_questions);
            db.SaveChanges();
            //
            var question = new MQuestion();
            //create new question
            if (string.IsNullOrEmpty(question_id))
            {
                question.EQuestionTypeIdFk = db.EQuestionAnswerType.First().Id;
                question.MCourseTopicIdFk = db.MCourseTopic.Where(i => i.CourseIdFk == course_id).First().Id;
                question.MCourseIdFk = course_id;
                question.QuestionSequence = 0;
                question.QuestionText = string.Empty;
                db.MQuestion.Add(question);
                db.SaveChanges();
            }
            else//fetch existing
            {
                question = db.MQuestion.Find(question_id);
            }
            //
            ViewBag.title = "Create Question";
            ViewBag.course = course;
            ViewBag.question = question;
            ViewBag.topics = db.MCourseTopic.Where(i => i.CourseIdFk == course_id).ToList();
            ViewBag.question_types = db.EQuestionAnswerType.ToList();
            return View();
        }



        [HttpPost("CreateQuestionAndAnswer")]
        public IActionResult CreateQuestionAndAnswer(MQuestion mQuestion)
        {
            try
            {
                db.Entry(mQuestion).State = EntityState.Modified;
                db.SaveChanges();
                TempData["msg"] = "Question Saved";
                TempData["type"] = "success";
            }
            catch(Exception ex)
            {
                TempData["msg"] = ex.Message;
                TempData["type"] = "error";
            }
            return RedirectToAction("CreateQuestionAndAnswer", new { question_id=mQuestion.Id,course_id=mQuestion.MCourseIdFk });
        }


        [HttpPost("DeleteQuestion")]
        public IActionResult DeleteQuestion(string id)
        {
            var question = db.MQuestion.Find(id);

            try
            {
                db.MQuestion.Remove(question);
                db.SaveChanges();
                TempData["msg"] = "Question rmoved";
                TempData["type"] = "success";
            }
            catch(Exception ex)
            {
                TempData["msg"] =ex.Message;
                TempData["type"] = "error";
            }
            return RedirectToAction("AllQuestions", new { course_id = question.MCourseIdFk });

        }



    }
}

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

    [Route("CourseMaterialQuestionsAndAnswers")]
    [Authorize(Roles = "system_admin")]
    public class CourseMaterialQuestionsAndAnswersController : Controller
    {
        private dbContext db = new dbContext();

        private readonly UserManager<IdentityUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public CourseMaterialQuestionsAndAnswersController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
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
        public IActionResult AllQuestions(string course_material_id)
        {
            ViewBag.title = "All Questions";
            var course_material = db.MCourseMaterial.Find(course_material_id);
            var course = db.MCourse.Find(course_material.MCourseIdFk);
            ViewBag.course_material = course_material;
            ViewBag.course = course;
            return View();
        }

        [HttpGet("ajaxAllQuestions")]
        public IActionResult ajaxAllQuestions(string course_material_id)
        {
            var questions = db.MCourseWorkQuestion
                 .Include(i => i.MCourseWorkQuestionAnswerOptions)
                .Include(i => i.EQuestionTypeIdFkNavigation)
                .Include(i => i.MCourseMaterialIdFkNavigation)
                .Where(i => i.MCourseMaterialIdFk == course_material_id)
                .ToList();
            ViewBag.questions = questions;
            return View();
        }

        [HttpGet("CreateQuestionAndAnswer")]
        public IActionResult CreateQuestionAndAnswer(string question_id,string course_material_id)
        {
            var course_material = db.MCourseMaterial.Find(course_material_id);
            //remove blanks left over
            var empty_questions = db.MCourseWorkQuestion.Where(i => i.QuestionText == string.Empty).ToList();
            db.MCourseWorkQuestion.RemoveRange(empty_questions);
            db.SaveChanges();
            //
            var question = new MCourseWorkQuestion();
            //create new question
            if (string.IsNullOrEmpty(question_id))
            {
                question.EQuestionTypeIdFk = db.EQuestionAnswerType.First().Id;
                question.MCourseMaterialIdFk = course_material.Id;
                question.QuestionSequence = 0;
                question.QuestionText = string.Empty;
                db.MCourseWorkQuestion.Add(question);
                db.SaveChanges();
            }
            else//fetch existing
            {
                question = db.MCourseWorkQuestion
                    .Where(i => i.Id == question_id)
                    .Include(i => i.MCourseWorkQuestionAnswerOptions)
                    .FirstOrDefault();
            }
            //
            ViewBag.title = "Create Question";
            ViewBag.course_material = course_material;
            ViewBag.question = question;
            ViewBag.question_types = db.EQuestionAnswerType.ToList();
            return View();
        }



        [HttpPost("CreateQuestionAndAnswer")]
        public IActionResult CreateQuestionAndAnswer(MCourseWorkQuestion question)
        {
            try
            {
                db.Entry(question).State = EntityState.Modified;
                db.SaveChanges();
                TempData["msg"] = "Question Saved";
                TempData["type"] = "success";
            }
            catch (Exception ex)
            {
                TempData["msg"] = ex.Message;
                TempData["type"] = "error";
            }
            return RedirectToAction("CreateQuestionAndAnswer", new { question_id = question.Id, course_material_id = question.MCourseMaterialIdFk });
        }


        [HttpPost("DeleteQuestion")]
        public IActionResult DeleteQuestion(string id)
        {
            var question = db.MCourseWorkQuestion.Find(id);

            try
            {
                db.MCourseWorkQuestion.Remove(question);
                db.SaveChanges();
                TempData["msg"] = "Question removed";
                TempData["type"] = "success";
            }
            catch (Exception ex)
            {
                TempData["msg"] = ex.Message;
                TempData["type"] = "error";
            }
            return RedirectToAction("AllQuestions", new { course_material_id = question.MCourseMaterialIdFk });

        }


        [HttpPost("AddAnswerOption")]
        public IActionResult AddAnswerOption(string question_id,string course_material_id, MCourseWorkQuestionAnswerOptions answer)
        {
            try
            {
                db.MCourseWorkQuestionAnswerOptions.Add(answer);
                db.SaveChanges();
                TempData["msg"] = "Answer Saved";
                TempData["type"] = "success";
            }
            catch (Exception ex)
            {
                TempData["msg"] = ex.Message;
                TempData["type"] = "error";
            }
            return RedirectToAction("CreateQuestionAndAnswer", new { question_id,course_material_id });
            
        }

        [HttpPost("SetIsCorrectAnswer")]
        public IActionResult SetIsCorrectAnswer(string answer_id, bool isCorrectAnswer, string course_material_id, string question_id)
        {
            try
            {
                var answer = db.MCourseWorkQuestionAnswerOptions.Find(answer_id);
                answer.IsCorrectAnswer = isCorrectAnswer;
                db.SaveChanges();
                TempData["msg"] = "Answer Saved";
                TempData["type"] = "success";
            }
            catch (Exception ex)
            {
                TempData["msg"] = ex.Message;
                TempData["type"] = "error";
            }
            return RedirectToAction("CreateQuestionAndAnswer", new { question_id, course_material_id });
        }

        [HttpPost("DeleteAnswerOption")]
        public IActionResult DeleteAnswerOption(string answer_id, string course_material_id, string question_id)
        {
            try
            {
                var answer = db.MCourseWorkQuestionAnswerOptions.Find(answer_id);
                db.Remove(answer);
                db.SaveChanges();
                TempData["msg"] = "Answer Removed";
                TempData["type"] = "success";
            }
            catch (Exception ex)
            {
                TempData["msg"] = ex.Message;
                TempData["type"] = "error";
            }
            return RedirectToAction("CreateQuestionAndAnswer", new { course_material_id, question_id });
        }


        [HttpPost("UpdateQuestionAnswerOptionExplanation")]
        public IActionResult UpdateQuestionAnswerOptionExplanation(string Id, string explanation,string course_material_id,string question_id)
        {
            var qao = db.MCourseWorkQuestionAnswerOptions.Find(Id);

            try
            {
                qao.Explanation = explanation;
                db.SaveChanges();
                TempData["type"] = "success";
                TempData["msg"] = "Saved";
            }
            catch (Exception ex)
            {
                TempData["type"] = "error";
                TempData["msg"] = ex.Message;
            }

            return RedirectToAction("CreateQuestionAndAnswer", new
            {
                course_material_id,
                question_id
            });

        }




    }
}

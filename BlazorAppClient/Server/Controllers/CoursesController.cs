using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BlazorAppClient.Server.Models;
using BlazorAppClient.Shared;
using BlazorAppClient.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace BlazorAppClient.Server.Controllers
{
    [Route("Courses")]
    public class CoursesController : Controller
    {
        private dbContext db = new dbContext();

        /// <summary>
        /// only fetch relevant information for the main menu
        /// optimise for network spead
        /// </summary>
        /// <param name="asp_net_user_id"></param>
        /// <param name="page_number"></param>
        /// <param name="page_size"></param>
        /// <returns></returns>
        [HttpGet("FetchMyCourses")]
        public JsonResult FetchMyCourses(string asp_net_user_id, int page_number = 0, int page_size = 10)
        {
            try
            {
                var my_courses = db.MCourseTakers
                    .Include(i => i.CourseIdFkNavigation)
                    .Where(i => i.AspNetUserIdFk == asp_net_user_id)
                    .ToList();

                var courses = my_courses
                    .Select(i => i.CourseIdFkNavigation)
                    .Skip(page_size * (page_number - 1))
                    .Take(page_size)
                    .ToList();

                var paging_meta_data = new PaginationMetaData()
                {
                    CurrentPage = page_number,
                    TotalPages = (int)Math.Ceiling(my_courses.Count / (double)page_size),
                    PageSize = page_size,
                    TotalCount = my_courses.Count
                };

                return Json(new
                {
                    res = "ok",
                    data = courses,
                    paging_meta_data
                }, new Newtonsoft.Json.JsonSerializerSettings()
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    res = "err",
                    data = ex.Message
                });
            }
        }


        /// <summary>
        /// optimized to fetch only relevant information
        /// </summary>
        /// <param name="course_id"></param>
        /// <param name="asp_net_user_id"></param>
        /// <returns></returns>
        [HttpGet("FetchCourse")]
        public JsonResult FetchCourse(string course_id, string asp_net_user_id)
        {
            try
            {
                var course_taker = db.MCourseTakers
                    .Where(i => i.AspNetUserIdFk == asp_net_user_id && i.CourseIdFk == course_id)
                    .Include(i => i.CourseIdFkNavigation)
                    .FirstOrDefault();

                return Json(new
                {
                    res = "ok",
                    data = course_taker.CourseIdFkNavigation
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    res = "err",
                    data = ex.Message
                });
            }
        }


        /// <summary>
        /// fetched the course and course material 
        /// also records course start time
        /// </summary>
        /// <param name="course_id"></param>
        /// <param name="asp_net_user_id"></param>
        /// <returns></returns>
        [HttpGet("StartCourse")]
        public JsonResult StartCourse(string course_id, string asp_net_user_id)
        {
            try
            {
                var course_taker = db.MCourseTakers
                    .Where(i => i.AspNetUserIdFk == asp_net_user_id && i.CourseIdFk == course_id)
                    .Any();
                if (!course_taker)
                {
                    return Json(new
                    {
                        res = "err",
                        data = "You cannot take this course"
                    });
                }

                var course = db.MCourse
                    .Where(i => i.Id == course_id)
                    .Include(i => i.MCourseMaterial)
                    .Include(i => i.MCourseTopic)
                    //.Include(i => i.MQuestion)
                    //.Include(i => i.MQuestionAnswerOptions)
                    .First();
                //
                //tell the client which pages are completed
                var completed_pages = db.MCourseWorkProgress
                    .Where(i => i.CourseIdFk == course_id && i.AspNetUserIdFk == asp_net_user_id)
                    .ToList();
                //
                var course_materials_base_64 = new List<BlazorAppClient.Server.Models.MCourseMaterial>();
                //var course_question_base_64 = new List<BlazorAppClient.Server.Models.MQuestion>();
                //
                foreach (var data in course.MCourseMaterial)
                {
                    //convert to base64
                    data.PageData = Globals.Base64Encode(data.PageData);
                    course_materials_base_64.Add(data);
                }
                ////
                //foreach (var data in course.MQuestion)
                //{
                //    //convert to base64
                //    data.QuestionText = Globals.Base64Encode(data.QuestionText);
                //    course_question_base_64.Add(data);
                //}
                //
                course.MCourseMaterial = course_materials_base_64;
                //course.MQuestion = course_question_base_64;

                //record course start time
                var start_time_exists = db.MCourseStartAndStopTime
                    .Where(i => i.AspNetUserIdFk == asp_net_user_id && i.CourseIdFk == course_id).Any();

                if(!start_time_exists)
                {
                    //record start time
                    var new_start_time = new MCourseStartAndStopTime();
                    new_start_time.AspNetUserIdFk = asp_net_user_id;
                    new_start_time.CourseStartTime = DateTime.Now;
                    new_start_time.CourseEndTime = DateTime.Now;
                    new_start_time.CourseIdFk = course_id;
                    db.MCourseStartAndStopTime.Add(new_start_time);
                    db.SaveChanges();
                }

                return Json(new
                {
                    res = "ok",
                    data = course,
                    completed_pages
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    res = "err",
                    data = ex.Message
                });
            }
        }


        //todo: record start the exam
        //returns the exam and also the users answers that are existing for this exam
        [HttpGet("StartExam")]
        public JsonResult StartExam(string course_id, string asp_net_user_id)
        {
            //todo record that this course has begun
            //and must be submitted by enddate
            try
            {
                var course_taker = db.MCourseTakers
                    .Where(i => i.AspNetUserIdFk == asp_net_user_id && i.CourseIdFk == course_id)
                    .Any();
                if (!course_taker)
                {
                    return Json(new
                    {
                        res = "err",
                        data = "You cannot take this exam"
                    });
                }

                var course = db.MCourse
                    .Where(i => i.Id == course_id)
                    //.Include(i => i.MCourseMaterial)
                    .Include(i => i.MCourseTopic)
                    .Include(i => i.MQuestion)
                    .Include(i => i.MQuestionAnswerOptions)
                    .First();

                var users_answers = db.MUsersAnswers
                    .Where(i => i.AspNetUserIdFk == asp_net_user_id
                && i.CourseIdFk == course_id)
                    .ToList();
                //
                //var course_materials_base_64 = new List<BlazorAppClient.Server.Models.MCourseMaterial>();
                var course_question_base_64 = new List<BlazorAppClient.Server.Models.MQuestion>();
                ////
                //foreach (var data in course.MCourseMaterial)
                //{
                //    //convert to base64
                //    data.PageData = Globals.Base64Encode(data.PageData);
                //    course_materials_base_64.Add(data);
                //}
                //
                foreach (var data in course.MQuestion)
                {
                    //convert to base64
                    data.QuestionText = Globals.Base64Encode(data.QuestionText);
                    course_question_base_64.Add(data);
                }
                //
                //course.MCourseMaterial = course_materials_base_64;
                course.MQuestion = course_question_base_64;

                return Json(new
                {
                    res = "ok",
                    data = course,
                    users_answers
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    res = "err",
                    data = ex.Message
                });
            }
        }


        [HttpGet("FetchReports")]
        public JsonResult FetchReports(string course_id, string asp_net_user_id)
        {
            try
            {
                //var course_taker = db.MCourseTakers
                //    .Where(i => i.AspNetUserIdFk == asp_net_user_id && i.CourseIdFk == course_id)
                //    .Any();
                //if (!course_taker)
                //{
                //    return Json(new
                //    {
                //        res = "err",
                //        data = "You cannot take this exam"
                //    });
                //}

                var course = db.MCourse
                    .Where(i => i.Id == course_id)
                    .Include(i => i.MCourseMaterial)
                    .Include(i => i.MCourseTopic)
                    .Include(i => i.MQuestion)
                    .Include(i => i.MQuestionAnswerOptions)
                    .First();
                //
                var users_answers = db.MUsersAnswers
                    .Where(i => i.AspNetUserIdFk == asp_net_user_id
                && i.CourseIdFk == course_id)
                    .ToList();
                //tell the client which pages are completed
                var completed_pages = db.MCourseWorkProgress
                    .Where(i => i.CourseIdFk == course_id && i.AspNetUserIdFk == asp_net_user_id)
                    .ToList();
                //
                var topic_percentage_completed = new Dictionary<string, int>();
                //
                foreach(var topic in course.MCourseTopic)
                {
                    var completion = (int)(((decimal)completed_pages.Count(i => i.TopicIdFk == topic.Id) / (decimal)course.MCourseMaterial.Count(i => i.MCourseTopicIdFk == topic.Id)) * 100);
                    topic_percentage_completed.Add(topic.Topic,completion);
                }
                //
                int course_percentage_complete = (int)(((decimal)completed_pages.Count / (decimal)course.MCourseMaterial.Count) * 100);
                int exam_percentage_complete = (int)(((decimal)users_answers.Count / (decimal)course.MQuestion.Count) * 100);
                //
                var exam_time = db.MCourseStartAndStopTime.Where(i => i.CourseIdFk == course_id && i.AspNetUserIdFk == asp_net_user_id).FirstOrDefault();
                var total_time = exam_time?.CourseEndTime - exam_time?.CourseStartTime;
                var time = total_time?.ToString() ?? TimeSpan.FromSeconds(0).ToString();
                //
                double exam_pass_percentage = 30;
                //
                return Json(new
                {
                    res = "ok",
                    course_percentage_complete,
                    exam_percentage_complete,
                    topic_percentage_completed,
                    exam_pass_percentage,
                    time
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    res = "err",
                    data = ex.Message
                });
            }
        }


        [HttpPost("UploadAnswerToServer")]
        public JsonResult UploadAnswerToServer([FromBody] BlazorAppClient.Server.Models.MUsersAnswers answer)
        {
            try
            {
                db.MUsersAnswers.Add(answer);
                db.SaveChanges();
                return Json(new
                {
                    res = "ok",
                    data = "Answer Saved"
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    res = "err",
                    data = ex.Message
                });
            }
        }


        [HttpPost("UpdateCourseProgress")]
        public JsonResult UpdateCourseProgress(string asp_net_user_id, string page_id, string course_id, string topic_id)
        {
            try
            {
                var course_work_progress = new BlazorAppClient.Server.Models.MCourseWorkProgress();
                course_work_progress.AspNetUserIdFk = asp_net_user_id;
                course_work_progress.CoursePageIdFk = page_id;
                course_work_progress.CourseIdFk = course_id;
                course_work_progress.TopicIdFk = topic_id;
                db.MCourseWorkProgress.Add(course_work_progress);
                db.SaveChanges();

                //tell the client which pages are completed
                var completed_pages = db.MCourseWorkProgress
                    .Where(i => i.CourseIdFk == course_id && i.AspNetUserIdFk == asp_net_user_id)
                    .ToList();

                return Json(new
                {
                    res = "ok",
                    data = "progress saved",
                    completed_pages
                });
            }
            catch (Exception ex)
            {
                return Json(new { res = "err", data = ex.Message });
            }
        }


        /// <summary>
        /// load the questions and answers for the selected page/course material
        /// </summary>
        /// <param name="course_material_id"></param>
        /// <param name="asp_net_user_id"></param>
        /// <returns></returns>
        [HttpGet("LoadQuestionsForCourseMaterial")]
        public JsonResult LoadQuestionsForCourseMaterial(string course_id,string course_material_id, string asp_net_user_id)
        {
            try
            {
                var course_taker = db.MCourseTakers
                    .Where(i => i.AspNetUserIdFk == asp_net_user_id && i.CourseIdFk == course_id)
                    .Any();
                //
                if (!course_taker)
                {
                    return Json(new
                    {
                        res = "err",
                        data = "You cannot take this course"
                    });
                }
                //
                var course_material_questions = db.MCourseWorkQuestion
                    .Where(i => i.MCourseMaterialIdFk == course_material_id)
                    .Include(i => i.MCourseWorkQuestionAnswerOptions)
                    .ToList();

                //tell the client which questions are completed
                var completed_questions_answers = db.MUsersAnswersCourseMaterial
                    .Where(i => i.CourseMaterialIdFk == course_material_id && i.AspNetUserIdFk == asp_net_user_id)
                    .ToList();
                //
                var course_material_questions_base_64 = new List<BlazorAppClient.Server.Models.MCourseWorkQuestion>();
                foreach (var data in course_material_questions)
                {
                    //convert to base64
                    data.QuestionText = Globals.Base64Encode(data.QuestionText);
                    course_material_questions_base_64.Add(data);
                }
                //
                return Json(new
                {
                    res = "ok",
                    data = course_material_questions_base_64,
                    completed_questions_answers
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    res = "err",
                    data = ex.Message
                });
            }
        }


        [HttpPost("UploadCourseMaterialAnswerToServer")]
        public JsonResult UploadCourseMaterialAnswerToServer([FromBody] BlazorAppClient.Server.Models.MUsersAnswersCourseMaterial answer)
        {
            try
            {
                db.MUsersAnswersCourseMaterial.Add(answer);
                db.SaveChanges();
                return Json(new
                {
                    res = "ok",
                    data = "Answer Saved"
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    res = "err",
                    data = ex.Message
                });
            }
        }




    }





}

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
using Humanizer;

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
                    .Where(i => i.Published)//published
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
                if (course_taker.CourseIdFkNavigation.Published)
                {
                    return Json(new
                    {
                        res = "ok",
                        data = course_taker.CourseIdFkNavigation
                    });
                }
                else
                {
                    return Json(new
                    {
                        res = "err",
                        data = "Course does not exist"
                    });
                }
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
                    .AsNoTracking()
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
                    .AsNoTracking()
                    .Where(i => i.Id == course_id)
                    .Include(i => i.MCourseMaterial)
                    .Include(i => i.MCourseTopic)
                    .Where(i => i.Published)
                    .First();

                if (course == null)
                {
                    return Json(new
                    {
                        res = "err",
                        data = "Course is not published or does not exist"
                    });
                }
                //
                //tell the client which pages are completed
                var completed_pages = db.MCourseWorkProgress
                    .AsNoTracking()
                    .Where(i => i.CourseIdFk == course_id && i.AspNetUserIdFk == asp_net_user_id)
                    .ToList();
                //
                var course_materials_base_64 = new List<BlazorAppClient.Server.Models.MCourseMaterial>();
                //var course_question_base_64 = new List<BlazorAppClient.Server.Models.MQuestion>();
                //
                foreach (var data in course.MCourseMaterial)
                {
                    //convert to base64
                    data.PageData = Globals.Base64Encode(data.PageData); ;
                    course_materials_base_64.Add(data);
                }
                //
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
                    .AsNoTracking()
                    .Where(i => i.AspNetUserIdFk == asp_net_user_id && i.CourseIdFk == course_id).Any();

                if (!start_time_exists)
                {
                    //record start time
                    var new_start_time = new BlazorAppClient.Server.Models.MCourseStartAndStopTime();
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
                    completed_pages,
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
        /// load the questions and answers for the selected page/course material
        /// </summary>
        /// <param name="course_material_id"></param>
        /// <param name="asp_net_user_id"></param>
        /// <returns></returns>
        [HttpGet("LoadQuestionsForCourseMaterial")]
        public JsonResult LoadQuestionsForCourseMaterial(string course_id, string course_material_id, string asp_net_user_id)
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

        /// <summary>
        /// load the board game for the selected page/course material
        /// </summary>
        /// <param name="course_material_id"></param>
        /// <param name="asp_net_user_id"></param>
        /// <returns></returns>
        [HttpGet("LoadBoardGameForCourseMaterial")]
        public JsonResult LoadBoardGameForCourseMaterial(string course_id, string course_material_id, string asp_net_user_id)
        {
            try
            {
                var board_game = db.MBoardGame.Where(i => i.CourseMaterialIdFk == course_material_id).FirstOrDefault();
                var board_game_titles = db.MBoardGameTitles.Where(i => i.MBoardGameIdFk == board_game.Id).ToList();
                var board_game_items = db.MBoardGameItems.Where(i => i.MBoardGameIdFk == board_game.Id).ToList();

                //the below logic is the same as UploadBoardGame
                //this is to check if there is already an answer and return that object to the client
                //
                var the_correct_answer_html_table = string.Empty;
                var my_selected_answer_html_table = string.Empty;
                bool is_my_answer_correct = true;//start at true break as soon as you hit a false
                var existing_answer = db.MBoardGameUsersAnswers
                    .Where(i => i.MCourseMaterialIdFk == course_material_id)//this course material
                    .Where(i => i.AspNetUserIdFk == asp_net_user_id)//this user
                    .FirstOrDefault();//only one board game per course material
                if (existing_answer!=null)
                {
                    //format the correct answers to be in the same format as my uploaded answers
                    var the_correct_answers = new List<BlazorAppClient.Shared.BoardGameItemsOrdering>();
                    //
                    foreach (var title in board_game_titles)
                    {
                        var items_under_this_title = board_game_items.Where(i => i.CorrectTitleIdFk == title.Id).Select(i => i.Id).ToList();
                        //
                        var order = new BlazorAppClient.Shared.BoardGameItemsOrdering();
                        order.title_id = title.Id;
                        order.item_ids.AddRange(items_under_this_title);
                        the_correct_answers.Add(order);
                    }
                    //compare my answers with the stored answers
                    var my_uploaded_answers = JsonConvert.DeserializeObject<List<BlazorAppClient.Shared.BoardGameItemsOrdering>>(existing_answer.JsonAnswer);
                    foreach (var correct_order in the_correct_answers)
                    {
                        var my_order = my_uploaded_answers.Where(i => i.title_id == correct_order.title_id).First();
                        //break as soon as you encounter one false
                        //
                        //first compare lengths if they are different this answer is wrong already
                        is_my_answer_correct = my_order.item_ids.Count == correct_order.item_ids.Count;
                        if (!is_my_answer_correct)
                        {
                            break;
                        }
                        //
                        //now compare the actual items each must be the same
                        for (int i = 0; i < correct_order.item_ids.Count; i++)
                        {
                            is_my_answer_correct = correct_order.item_ids[i] == correct_order.item_ids[i];
                            if (!is_my_answer_correct)
                            {
                                break;
                            }
                        }
                        if (!is_my_answer_correct)
                        {
                            break;
                        }
                    }
                    the_correct_answer_html_table += "<table >";
                    the_correct_answer_html_table += "<tr>";
                    foreach (var title in the_correct_answers)
                    {
                        the_correct_answer_html_table += $"<td style='border:1px solid black;'>{db.MBoardGameTitles.Find(title.title_id).Title}</td>";
                    }
                    the_correct_answer_html_table += "</tr>";


                    the_correct_answer_html_table += "</table>";

                    my_selected_answer_html_table = the_correct_answer_html_table;

                    //put into base64
                    //my_selected_answer_html_table = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(my_selected_answer_html_table));
                    //the_correct_answer_html_table = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(the_correct_answer_html_table));
                }
                //
                return Json(new
                {
                    res = "ok",
                    board_game,
                    board_game_titles,
                    board_game_items,
                    the_correct_answer_html_table,
                    my_selected_answer_html_table,
                    is_my_answer_correct
                });
            }
            catch (Exception ex)
            {
                //
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
                    .Where(i => i.Published)
                    //.Include(i => i.MCourseMaterial)
                    .Include(i => i.MCourseTopic)
                    .Include(i => i.MQuestion)
                    .Include(i => i.MQuestionAnswerOptions)
                    .First();

                if (course == null)
                {
                    return Json(new
                    {
                        res = "err",
                        data = "Course is not published or does not exist"
                    });
                }

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

                //check if the course work is completed
                var completed_course_work_material = db.MCourseWorkProgress
                    .Where(i => i.CourseIdFk == course_id)
                    .Where(i => i.AspNetUserIdFk == asp_net_user_id)
                    .Count();

                var number_of_course_material = db.MCourseMaterial
                    .Where(i => i.MCourseIdFk == course_id)
                    .ToList();

                //compare my course progress against the number of course work material
                //if they are the same then course work is completed
                //if not then i have not completed the course work
                var is_course_work_completed = number_of_course_material.Count() == completed_course_work_material;

                //if i have not completed the course work no need to check this also
                //only check i have answered all inline questions in the course work if is_course_work_completed==true
                if (is_course_work_completed)
                {
                    //check if all questions in course material have been answered
                    foreach (var material in number_of_course_material)
                    {
                        var course_work_material_questions = db.MCourseWorkQuestion
                                   .Where(i => i.MCourseMaterialIdFk == material.Id)
                                   .Count();
                        var my_course_work_answers = db.MUsersAnswersCourseMaterial
                            .Where(i => i.AspNetUserIdFk == asp_net_user_id)
                            .Where(i => i.CourseMaterialIdFk == material.Id)
                            .Count();

                        is_course_work_completed = course_work_material_questions == my_course_work_answers;
                        if (!is_course_work_completed)
                        {
                            break;//end the loop as soon as i get a single false
                            //this means there is at least one that is not completed
                        }

                    }
                }

                return Json(new
                {
                    is_course_work_completed,
                    res = "ok",
                    data = course,
                    users_answers,
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
                    .Where(i => i.Published)
                    .Include(i => i.MCourseMaterial)
                    .Include(i => i.MCourseTopic)
                    .Include(i => i.MQuestion)
                    .Include(i => i.MQuestionAnswerOptions)
                    .First();

                if (course == null)
                {
                    return Json(new
                    {
                        res = "err",
                        data = "Course is not published or does not exist"
                    });
                }
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
                foreach (var topic in course.MCourseTopic)
                {
                    int completion = 0;
                    decimal cource_material_count = (decimal)course.MCourseMaterial.Count(i => i.MCourseTopicIdFk == topic.Id);
                    if (cource_material_count == 0)//prevent devide by zero error
                    {
                        completion = 0;
                        topic_percentage_completed.Add(topic.Topic, completion);
                        continue;//skip
                    }
                    completion = (int)(((decimal)completed_pages.Count(i => i.TopicIdFk == topic.Id) / cource_material_count) * 100);
                    topic_percentage_completed.Add(topic.Topic, completion);
                }
                //
                decimal course_material_count = (decimal)course.MCourseMaterial.Count;
                decimal course_question_count = (decimal)course.MQuestion.Count;
                int course_percentage_complete = 0;
                int exam_percentage_complete = 0;
                //
                if (course_material_count != 0)//prevent devide by zero exception
                {
                    course_percentage_complete = (int)(((decimal)completed_pages.Count / course_material_count) * 100);
                }
                //
                if (course_question_count != 0)//prevent devide by zero exception
                {
                    exam_percentage_complete = (int)(((decimal)users_answers.Count / course_question_count) * 100);
                }
                //
                var exam_time = db.MCourseStartAndStopTime.Where(i => i.CourseIdFk == course_id && i.AspNetUserIdFk == asp_net_user_id).FirstOrDefault();
                var total_time = exam_time?.CourseEndTime - exam_time?.CourseStartTime;
                var time = total_time?.Humanize(3) ?? TimeSpan.FromSeconds(0).Humanize(3);
                //
                var assesments = db.MContinouseAssesment
                    .Where(i => i.MCourseIdFk == course_id)
                    .ToList();
                var _assesments = new List<BlazorAppClient.Shared.Models._MContinouseAssesment>();//_MContinouseAssesment strips down the irrelevant members, this streamlines the response and makes it faster
                var _continous_assesment_marks = new List<BlazorAppClient.Shared.Models._MUsersAssesmentMarks>();//strips down the irrelevant members
                foreach (var assesment in assesments)
                {
                    //
                    _assesments.Add(new BlazorAppClient.Shared.Models._MContinouseAssesment()
                    {
                        Id = assesment.Id,
                        AssesmentName = assesment.AssesmentName,
                        Description = assesment.Description,
                        MCourseIdFk = assesment.MCourseIdFk
                    });
                    //
                    var score = db.MUsersAssesmentMarks
                    .Where(i => i.AspNetUserIdFk == asp_net_user_id && i.MContinouseAssesmentIdFk == assesment.Id)
                    .FirstOrDefault();
                    //
                    if (score != null)
                    {
                        _continous_assesment_marks.Add(new _MUsersAssesmentMarks()
                        {
                            MContinouseAssesmentIdFk = score.MContinouseAssesmentIdFk,
                            Percentage = score.Percentage,
                            Comments = score.Comments
                        });
                    }
                }
                //
                double exam_pass_percentage = ((double)db.MUsersAnswers.Where(i => i.AspNetUserIdFk == asp_net_user_id && i.CorrectAnswer && i.CourseIdFk == course_id).Count() / ((double)db.MQuestion.Where(i => i.MCourseIdFk == course_id).Count()) * 100);
                double course_work_pass_percentage = 0;
                //
                var all_course_material = db.MCourseMaterial.Include(i => i.MCourseWorkQuestion).Where(i => i.MCourseIdFk == course_id).ToList();
                double all_course_material_questions = 0;
                double all_course_material_questions_correct = 0;
                //
                foreach (var m in all_course_material)
                {
                    all_course_material_questions += m.MCourseWorkQuestion.Count;
                    all_course_material_questions_correct += db.MUsersAnswersCourseMaterial.Where(i => i.CourseMaterialIdFk == m.Id && i.CorrectAnswer).Count();
                }
                //
                course_work_pass_percentage = (all_course_material_questions_correct / all_course_material_questions) * 100;
                //
                double over_all_total_score_percentage = course_work_pass_percentage + exam_pass_percentage + (double)_continous_assesment_marks.Sum(i => i.Percentage);
                //assesments.count + course_work_pass_percentage + exam_pass_percentage
                double over_all_total_score_percentage_total_items = assesments.Count + 1 + 1;
                //
                double over_all_percentage_score = over_all_total_score_percentage / over_all_total_score_percentage_total_items; //already in percentage
                return Json(new
                {
                    res = "ok",
                    course_percentage_complete,
                    exam_percentage_complete,
                    topic_percentage_completed,
                    exam_pass_percentage,
                    course_work_pass_percentage,
                    over_all_percentage_score,
                    time,
                    _assesments,
                    _continous_assesment_marks
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
        /// end the exam when the last question is answered and save the end time
        /// </summary>
        /// <param name="answer"></param>
        /// <returns></returns>
        [HttpPost("UploadAnswerToServer")]
        public JsonResult UploadAnswerToServer([FromBody] BlazorAppClient.Server.Models.MUsersAnswers answer)
        {
            try
            {
                db.MUsersAnswers.Add(answer);
                db.SaveChanges();

                var exam_questions_count = db.MQuestion
                    .Count(i => i.MCourseIdFk == answer.CourseIdFk);

                var answers_count = db.MUsersAnswers
                    .Count(i => i.AspNetUserIdFk == answer.AspNetUserIdFk);
                //end the exam
                if (exam_questions_count == answers_count)
                {
                    var time = db.MCourseStartAndStopTime
                        .Where(i => i.AspNetUserIdFk == answer.AspNetUserIdFk)
                        .Where(i => i.CourseIdFk == answer.CourseIdFk)
                        .FirstOrDefault();
                    time.CourseEndTime = DateTime.Now;
                    db.SaveChanges();
                }

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


        [HttpPost("UploadBoardGameAnswers")]
        public JsonResult UploadBoardGameAnswers([FromBody]BlazorAppClient.Server.Models.MBoardGameUsersAnswers answer)
        {
            try
            {
                //
                var the_correct_answer_html_table = string.Empty;
                var my_selected_answer_html_table = string.Empty;
                bool is_my_answer_correct = true;//start at true break as soon as you hit a false
                //
                var board_game = db.MBoardGame.Where(i => i.CourseMaterialIdFk == answer.MCourseMaterialIdFk).FirstOrDefault();
                var board_game_titles = db.MBoardGameTitles.Where(i => i.MBoardGameIdFk == board_game.Id).ToList();
                var board_game_items = db.MBoardGameItems.Where(i => i.MBoardGameIdFk == board_game.Id).ToList();
                //
                //format the correct answers to be in the same format as my uploaded answers
                var the_correct_answers = new List<BlazorAppClient.Shared.BoardGameItemsOrdering>();
                //
                foreach (var title in board_game_titles)
                {
                    var items_under_this_title = board_game_items.Where(i => i.CorrectTitleIdFk == title.Id).Select(i => i.Id).ToList();
                    //
                    var order = new BlazorAppClient.Shared.BoardGameItemsOrdering();
                    order.title_id = title.Id;
                    order.item_ids.AddRange(items_under_this_title);
                    the_correct_answers.Add(order);
                }
                //compare my answers with the stored answers
                var my_uploaded_answers = JsonConvert.DeserializeObject<List<BlazorAppClient.Shared.BoardGameItemsOrdering>>(answer.JsonAnswer);
                foreach (var correct_order in the_correct_answers)
                {
                    var my_order = my_uploaded_answers.Where(i => i.title_id == correct_order.title_id).First();
                    //break as soon as you encounter one false
                    //
                    //first compare lengths if they are different this answer is wrong already
                    is_my_answer_correct = my_order.item_ids.Count == correct_order.item_ids.Count;
                    if (!is_my_answer_correct)
                    {
                        break;
                    }
                    //
                    //now compare the actual items each must be the same
                    for (int i = 0; i < correct_order.item_ids.Count; i++)
                    {
                        is_my_answer_correct = correct_order.item_ids[i] == correct_order.item_ids[i];
                        if (!is_my_answer_correct)
                        {
                            break;
                        }
                    }
                    if (!is_my_answer_correct)
                    {
                        break;
                    }
                }
                answer.CorrectAnswer = is_my_answer_correct;
                //
                db.MBoardGameUsersAnswers.Add(answer);
                db.SaveChanges();
                //

                the_correct_answer_html_table += "<table>";
                the_correct_answer_html_table += "<tr>";
                foreach(var title in the_correct_answers)
                {
                    the_correct_answer_html_table += $"<td>{title.title_id}</td>";
                }
                the_correct_answer_html_table += "</tr>";


                the_correct_answer_html_table += "</table>";

                my_selected_answer_html_table = the_correct_answer_html_table;
                return Json(new
                {
                    res = "ok",
                    the_correct_answer_html_table,
                    my_selected_answer_html_table,
                    is_my_answer_correct
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

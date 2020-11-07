using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BlazorAppClient.Server.Models;
using BlazorAppClient.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace BlazorAppClient.Server.Controllers
{
    [Route("Courses")]
    public class CoursesController : Controller
    {
        private dbContext db = new dbContext();

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



        [HttpGet("StartCourse")]
        public JsonResult StartCourse(string course_id, string asp_net_user_id)
        {
            //todo record that this course has begun
            //and must be submitted by enddate
            try
            {
                var course_taker = db.MCourseTakers
                    .Where(i => i.AspNetUserIdFk == asp_net_user_id && i.CourseIdFk == course_id)
                    .Any();
                if(!course_taker)
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
                    .First();

                var course_materials_base_64 = new List<MCourseMaterial>();
                foreach(var data in course.MCourseMaterial)
                {
                    //convert to base64
                    data.PageData = Globals.Base64Encode(data.PageData);
                    course_materials_base_64.Add(data);
                }
                course.MCourseMaterial = course_materials_base_64;

                return Json(new
                {
                    res = "ok",
                    data = course
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
                if(!course_taker)
                {
                    return Json(new
                    {
                        res = "err",
                        data = "You cannot take this exam"
                    });
                }

                var course = db.MCourse
                    .Where(i => i.Id == course_id)
                    .Include(i => i.MCourseMaterial)
                    .Include(i => i.MCourseTopic)
                    .First();

                var course_materials_base_64 = new List<MCourseMaterial>();
                foreach(var data in course.MCourseMaterial)
                {
                    //convert to base64
                    data.PageData = Globals.Base64Encode(data.PageData);
                    course_materials_base_64.Add(data);
                }
                course.MCourseMaterial = course_materials_base_64;

                return Json(new
                {
                    res = "ok",
                    data = course
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

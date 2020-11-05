using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorAppClient.Server.Models;
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
        public JsonResult FetchMyCourses(string asp_net_user_id)
        {
            try
            {
                var my_courses = db.MCourseTakers
                    .Include(i => i.CourseIdFkNavigation)
                    .Where(i => i.AspNetUserIdFk == asp_net_user_id)
                    .ToList();
                var courses = my_courses.Select(i => i.CourseIdFkNavigation).ToList();
                return Json(new
                {
                    res = "ok",
                    data = courses
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
    }
}

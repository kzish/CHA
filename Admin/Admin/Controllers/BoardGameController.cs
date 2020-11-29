using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace Admin.Controllers
{
    [Route("BoardGame")]
    public class BoardGameController : Controller
    {
        private dbContext db = new dbContext();


        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            db.Dispose();
        }

        [HttpPost("AddTitle")]
        public IActionResult AddTitle(MBoardGameTitles _title, string course_material_id)
        {
            try
            {
                db.MBoardGameTitles.Add(_title);
                db.SaveChanges();
                TempData["type"] = "success";
                TempData["msg"] = "Saved";
            }
            catch (Exception ex)
            {
                TempData["type"] = "error";
                TempData["msg"] = ex.Message;
            }
            return RedirectToAction("BoardGame", "CourseMaterialQuestionsAndAnswers", new
            {
                course_material_id
            });

        }


        [HttpPost("AddItem")]
        public IActionResult AddItem(MBoardGameItems _item, string course_material_id)
        {
            try
            {
                db.MBoardGameItems.Add(_item);
                db.SaveChanges();
                TempData["type"] = "success";
                TempData["msg"] = "Saved";
            }
            catch (Exception ex)
            {
                TempData["type"] = "error";
                TempData["msg"] = ex.Message;
            }
            return RedirectToAction("BoardGame", "CourseMaterialQuestionsAndAnswers", new
            {
                course_material_id
            });

        }

         [HttpPost("DeleteTitle")]
        public IActionResult DeleteTitle(string id, string course_material_id)
        {
            try
            {
                var item = db.MBoardGameTitles.Find(id);
                db.MBoardGameTitles.Remove(item);
                db.SaveChanges();
                TempData["type"] = "success";
                TempData["msg"] = "Title Removed";
            }
            catch (Exception ex)
            {
                TempData["type"] = "error";
                TempData["msg"] = ex.Message;
            }
            return RedirectToAction("BoardGame", "CourseMaterialQuestionsAndAnswers", new
            {
                course_material_id
            });

        }

        [HttpPost("DeleteItem")]
        public IActionResult DeleteItem(string id, string course_material_id)
        {
            try
            {
                var item = db.MBoardGameItems.Find(id);
                db.MBoardGameItems.Remove(item);
                db.SaveChanges();
                TempData["type"] = "success";
                TempData["msg"] = "Item Removed";
            }
            catch (Exception ex)
            {
                TempData["type"] = "error";
                TempData["msg"] = ex.Message;
            }
            return RedirectToAction("BoardGame", "CourseMaterialQuestionsAndAnswers", new
            {
                course_material_id
            });

        }


    }
}

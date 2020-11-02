using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Admin.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeTypes;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Admin.Controllers
{
    [Route("Media")]
    public class MediaController : Controller
    {
        private IHostingEnvironment host;

        private dbContext db = new dbContext();

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            db.Dispose();
        }

        public MediaController(IHostingEnvironment host)
        {
            this.host = host;
        }
        [HttpGet("UploadMediaFile")]
        public IActionResult UploadMediaFile()
        {

            return View();
        }

        [HttpPost("UploadMediaFile")]
        public async Task<JsonResult> UploadMediaFile(List<IFormFile> files_)
        {
            var files = Request.Form.Files;
            try
            {
                foreach (var formFile in files)
                {
                    if (formFile.Length > 0)
                    {
                        //
                        var file_name = Guid.NewGuid().ToString() + Path.GetExtension(formFile.FileName);
                        var media = new MMedia();
                        media.IdFileNameGuid = file_name;
                        media.OriginalFileName = formFile.FileName;
                        db.MMedia.Add(media);
                        db.SaveChanges();
                        //
                        using (var stream = System.IO.File.Create($"{Globals.uploads_folder}/{file_name}"))
                        {
                            await formFile.CopyToAsync(stream);
                        }
                    }
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
            return Json(new
            {
                res = "ok",
                data = "saved"
            });
        }


        [HttpGet("ListFiles")]
        public IActionResult ListFiles()
        {
            var files = db.MMedia.ToList();
            ViewBag.files = files;
            return View();
        }


        [HttpGet("PreviewFile/{file_id}")]
        public FileStreamResult PreviewFile(string file_id)
        {
            var path = $"{Globals.uploads_folder}/{file_id}";
            var stream = System.IO.File.OpenRead(path);
            var file_extension = Path.GetExtension(file_id).Replace(".", "");

            var mime_type = MimeTypeMap.GetMimeType(file_extension);
            if (!string.IsNullOrEmpty(mime_type))
            {
                return new FileStreamResult(stream, mime_type);
            }
            else
            {
                return new FileStreamResult(stream, "application/octet-stream");
            }


        }

        [HttpPost("DeleteMediaFile")]
        public JsonResult DeleteMediaFile(string id)
        {
            try
            {
                var media = db.MMedia.Find(id);
                System.IO.File.Delete($"{Globals.uploads_folder}/{media.IdFileNameGuid}");
                db.MMedia.Remove(media);
                db.SaveChanges();
                return Json(new
                {
                    res = "ok",
                    data = "deleted"
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

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Admin.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
                        var file_name = Guid.NewGuid().ToString()+Path.GetExtension(formFile.FileName);
                        var media = new MMedia();
                        media.IdFileNameGuid = file_name;
                        media.OriginalFileName = formFile.FileName;
                        db.MMedia.Add(media);
                        db.SaveChanges();
                        //
                        using (var stream = System.IO.File.Create($"C:/CHA/{file_name}"))
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


    }
}

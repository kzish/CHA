using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace Admin.Controllers
{
    [Route("Media")]
    public class MediaController : Controller
    {

        [HttpGet("PreviewFile/{file_id}")]
        public FileStreamResult PreviewFile(string file_id)
        {
            var path = $"{Globals.uploads_folder}/{file_id}";
            var stream = System.IO.File.OpenRead(path);
            var file_extension = Path.GetExtension(file_id).Replace(".", "");

            if (MIMETYPES.mime_types.ContainsKey(file_extension))
            {
                return new FileStreamResult(stream, MIMETYPES.mime_types[file_extension]);
            }
            else
            {
                //download unknown file extension
                return new FileStreamResult(stream, "application/octet-stream");
            }


        }

    }
}

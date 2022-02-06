//using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Angular_Js_Project.Controllers
//{
//    [ApiController]
//    public class FileUploadController : ControllerBase
//    {
//        private readonly IWebHostEnvironment iWebHostEnvironment;
//        public FileUploadController(IWebHostEnvironment _iWebHostEnvironment)
//        {
//            iWebHostEnvironment = _iWebHostEnvironment;
//        }
//        [Route("api/FileAPI/PsngrImageUpload")]
//        [HttpPost]
//        public IActionResult PsngrImageUpload()
//        {
//            IFormFile Photo = null;
//            string uniqueImageName = null;
//            var files = HttpContext.Request.Form.Files;
//            foreach (IFormFile photo in HttpContext.Request.Form.Files)
//            {
//                Photo = photo;
//            }
//            if (Photo != null)
//            {
//                string uploadFolder = Path.Combine(iWebHostEnvironment.WebRootPath, "Images");
//                uniqueImageName = Photo.FileName;
//                string filePath = Path.Combine(uploadFolder, uniqueImageName);
//                FileStream fileStream = new FileStream(filePath, FileMode.Create);
//                Photo.CopyTo(fileStream);
//                fileStream.Close();
//            }

//            return Ok();
//        }
//    }
//}

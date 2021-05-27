using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactFileUploadDemo.Web.Controllers
{
    public class ImagesController : Controller
    {
        public IActionResult ViewImage(string name)
        {
            byte[] imageData = System.IO.File.ReadAllBytes($"uploads/{name}");
            return File(imageData, "APPLICATION/octet-stream", name);
        }

        public IActionResult GetCsv()
        {
            var foo = "hello,world";
            var bytes = Encoding.UTF8.GetBytes(foo);
            return File(bytes, "text/csv", "test.csv");
        }
    }
}

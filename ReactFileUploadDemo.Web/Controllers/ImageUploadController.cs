using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using ReactFileUploadDemo.Web.ViewModels;

namespace ReactFileUploadDemo.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageUploadController : ControllerBase
    {
        [HttpPost]
        [Route("upload")]
        public void Upload(ImageUploadViewModel viewModel)
        {
            int commaIndex = viewModel.Base64File.IndexOf(',');
            string base64 = viewModel.Base64File.Substring(commaIndex + 1);
            
            byte[] fileData = Convert.FromBase64String(base64);
            System.IO.File.WriteAllBytes($"uploads/{viewModel.Name}", fileData);
        }
    }
}

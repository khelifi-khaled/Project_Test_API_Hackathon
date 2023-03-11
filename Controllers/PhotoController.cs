
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Project_Test_API_Hackathon.Entities;
using System;
using System.Reflection;


namespace Project_Test_API_Hackathon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotoController : ControllerBase
    {
        private readonly IWebHostEnvironment _env;


        public PhotoController(IWebHostEnvironment env)
        {
            _env = env;
        }




        // POST api/<PhotoController>
        [HttpPost]
        public IActionResult Post([FromForm] Photo modelPhoto)
        {

            try
            {

                if (modelPhoto == null)
                {
                    return Content("Invalid Submission!");
                }

                if (modelPhoto.PhotoFile.FileName == null || modelPhoto.PhotoFile.FileName.Length == 0)
                {
                    return Content("File not selected");
                }


                if (string.IsNullOrWhiteSpace(_env.WebRootPath))
                {
                    _env.WebRootPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
                }

                var path = Path.Combine(_env.WebRootPath, "Images/", modelPhoto.PhotoFile.FileName);


                using (FileStream stream = new (path, FileMode.Create))
                {
                    modelPhoto.PhotoFile.CopyTo(stream);
                    stream.Close();
                }






            }
            catch
            {
                return BadRequest();
            }

            return Ok();


        }




    }
}

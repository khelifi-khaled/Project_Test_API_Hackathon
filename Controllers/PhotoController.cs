
using Azure.AI.Vision.Core.Input;
using Azure.AI.Vision.Core.Options;
using Azure.AI.Vision.ImageAnalysis;
using Microsoft.AspNetCore.Mvc;
using Project_Test_API_Hackathon.Entities;

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
                string endPoint = "https://citizen-vision.cognitiveservices.azure.com";

                var serviceOptions = new VisionServiceOptions(
                endPoint,
                "6802e6ab7e744944b198bbc2c8f20215");

                //var imageSource = VisionSource.FromUrl($"{endPoint}/{route}/Images/{modelPhoto.PhotoName}"));
                
                string wwwroot = _env.WebRootPath;
                var imageSource = VisionSource.FromFile($"{wwwroot}/Images/{modelPhoto.PhotoFile.FileName}");


                //var imageSource = VisionSource.FromUrl("https://i.pinimg.com/originals/4f/6cc4/4f6cc46e50e7a0ff21c5e0a77423b0b5.jpg");

                var analysisOptions = new ImageAnalysisOptions()
                {
                    Features = ImageAnalysisFeature.Caption | ImageAnalysisFeature.Text,

                    Language = "en",

                    GenderNeutralCaption = true
                };

                using var analyzer = new ImageAnalyzer(serviceOptions, imageSource, analysisOptions);


                var result = analyzer.Analyze();


                return Ok(result);


            //    if (result.Reason == ImageAnalysisResultReason.Analyzed)
            //    {
            //        if (result.Caption != null)
            //        {
            //            Console.WriteLine(" Caption:");
            //            Console.WriteLine($"   \"{result.Caption.Content}\", Confidence {result.Caption.Confidence:0.0000}");
            //        }

            //        if (result.Text != null)
            //        {
            //            Console.WriteLine($" Text:");
            //            foreach (var line in result.Text.Lines)
            //            {
            //                string pointsToString = "{" + string.Join(',', line.BoundingPolygon.Select(pointsToString => pointsToString.ToString())) + "}";
            //                Console.WriteLine($"   Line: '{line.Content}', Bounding polygon {pointsToString}");

            //                foreach (var word in line.Words)
            //                {
            //                    pointsToString = "{" + string.Join(',', word.BoundingPolygon.Select(pointsToString => pointsToString.ToString())) + "}";
            //                    Console.WriteLine($"     Word: '{word.Content}', Bounding polygon {pointsToString}, Confidence {word.Confidence:0.0000}");
            //                }
            //            }
            //        }
            //    }
            //    else if (result.Reason == ImageAnalysisResultReason.Error)
            //    {
            //        var errorDetails = ImageAnalysisErrorDetails.FromResult(result);
            //        Console.WriteLine(" Analysis failed.");
            //        Console.WriteLine($"   Error reason : {errorDetails.Reason}");
            //        Console.WriteLine($"   Error code : {errorDetails.ErrorCode}");
            //        Console.WriteLine($"   Error message: {errorDetails.Message}");
            //    }
            



            //    //HttpContent httpContent = new StringContent(JsonSerializer.Serialize(modelPhoto.PhotoFile));

            ////httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            ////httpContent.Headers.Add("Authorization", "6802e6ab7e744944b198bbc2c8f20215");

            ////HttpResponseMessage message = _httpClient.CreateClient("Default")
            ////    .PostAsync($"cognitive-services/computer-vision/media/quickstarts/{path}", httpContent).Result ;

            ////message.EnsureSuccessStatusCode();








            }
            catch
            {
                return BadRequest();
            }

        }




    }
}


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

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(@"{
  ""reason"": 2,
  ""modelVersion"": ""2023-02-01-preview"",
  ""imageHeight"": 1653,
  ""imageWidth"": 1242,
  ""caption"": {
    ""content"": ""two men taking a selfie"",
    ""confidence"": 0.6280351877212524
  },
  ""tags"": null,
  ""customTags"": null,
  ""objects"": null,
  ""customObjects"": null,
  ""people"": null,
  ""text"": {
    ""lines"": [
      {
        ""content"": ""- KHALED APY"",
        ""boundingPolygon"": [
          {
            ""isEmpty"": false,
            ""x"": 989,
            ""y"": 559
          },
          {
            ""isEmpty"": false,
            ""x"": 1120,
            ""y"": 570
          },
          {
            ""isEmpty"": false,
            ""x"": 1118,
            ""y"": 594
          },
          {
            ""isEmpty"": false,
            ""x"": 987,
            ""y"": 583
          }
        ],
        ""words"": [
          {
            ""content"": ""-"",
            ""confidence"": 0.396,
            ""boundingPolygon"": [
              {
                ""isEmpty"": false,
                ""x"": 991,
                ""y"": 559
              },
              {
                ""isEmpty"": false,
                ""x"": 1004,
                ""y"": 560
              },
              {
                ""isEmpty"": false,
                ""x"": 1001,
                ""y"": 585
              },
              {
                ""isEmpty"": false,
                ""x"": 987,
                ""y"": 583
              }
            ]
          },
          {
            ""content"": ""KHALED"",
            ""confidence"": 0.52,
            ""boundingPolygon"": [
              {
                ""isEmpty"": false,
                ""x"": 1010,
                ""y"": 561
              },
              {
                ""isEmpty"": false,
                ""x"": 1071,
                ""y"": 566
              },
              {
                ""isEmpty"": false,
                ""x"": 1068,
                ""y"": 591
              },
              {
                ""isEmpty"": false,
                ""x"": 1006,
                ""y"": 585
              }
            ]
          },
          {
            ""content"": ""APY"",
            ""confidence"": 0.341,
            ""boundingPolygon"": [
              {
                ""isEmpty"": false,
                ""x"": 1081,
                ""y"": 567
              },
              {
                ""isEmpty"": false,
                ""x"": 1119,
                ""y"": 572
              },
              {
                ""isEmpty"": false,
                ""x"": 1116,
                ""y"": 595
              },
              {
                ""isEmpty"": false,
                ""x"": 1078,
                ""y"": 592
              }
            ]
          }
        ]
      },
      {
        ""content"": ""Fend"",
        ""boundingPolygon"": [
          {
            ""isEmpty"": false,
            ""x"": 995,
            ""y"": 588
          },
          {
            ""isEmpty"": false,
            ""x"": 1033,
            ""y"": 592
          },
          {
            ""isEmpty"": false,
            ""x"": 1032,
            ""y"": 613
          },
          {
            ""isEmpty"": false,
            ""x"": 994,
            ""y"": 608
          }
        ],
        ""words"": [
          {
            ""content"": ""Fend"",
            ""confidence"": 0.288,
            ""boundingPolygon"": [
              {
                ""isEmpty"": false,
                ""x"": 995,
                ""y"": 588
              },
              {
                ""isEmpty"": false,
                ""x"": 1031,
                ""y"": 592
              },
              {
                ""isEmpty"": false,
                ""x"": 1029,
                ""y"": 612
              },
              {
                ""isEmpty"": false,
                ""x"": 994,
                ""y"": 608
              }
            ]
          }
        ]
      },
      {
        ""content"": ""/bicode"",
        ""boundingPolygon"": [
          {
            ""isEmpty"": false,
            ""x"": 22,
            ""y"": 1016
          },
          {
            ""isEmpty"": false,
            ""x"": 110,
            ""y"": 1113
          },
          {
            ""isEmpty"": false,
            ""x"": 88,
            ""y"": 1133
          },
          {
            ""isEmpty"": false,
            ""x"": 0,
            ""y"": 1034
          }
        ],
        ""words"": [
          {
            ""content"": ""/bicode"",
            ""confidence"": 0.601,
            ""boundingPolygon"": [
              {
                ""isEmpty"": false,
                ""x"": 30,
                ""y"": 1023
              },
              {
                ""isEmpty"": false,
                ""x"": 104,
                ""y"": 1106
              },
              {
                ""isEmpty"": false,
                ""x"": 83,
                ""y"": 1127
              },
              {
                ""isEmpty"": false,
                ""x"": 6,
                ""y"": 1042
              }
            ]
          }
        ]
      },
      {
        ""content"": ""www.technofuturtic.be"",
        ""boundingPolygon"": [
          {
            ""isEmpty"": false,
            ""x"": 698,
            ""y"": 1427
          },
          {
            ""isEmpty"": false,
            ""x"": 790,
            ""y"": 1291
          },
          {
            ""isEmpty"": false,
            ""x"": 805,
            ""y"": 1299
          },
          {
            ""isEmpty"": false,
            ""x"": 712,
            ""y"": 1436
          }
        ],
        ""words"": [
          {
            ""content"": ""www.technofuturtic.be"",
            ""confidence"": 0.875,
            ""boundingPolygon"": [
              {
                ""isEmpty"": false,
                ""x"": 699,
                ""y"": 1428
              },
              {
                ""isEmpty"": false,
                ""x"": 789,
                ""y"": 1293
              },
              {
                ""isEmpty"": false,
                ""x"": 804,
                ""y"": 1301
              },
              {
                ""isEmpty"": false,
                ""x"": 711,
                ""y"": 1436
              }
            ]
          }
        ]
      },
      {
        ""content"": ""te"",
        ""boundingPolygon"": [
          {
            ""isEmpty"": false,
            ""x"": 834,
            ""y"": 1610
          },
          {
            ""isEmpty"": false,
            ""x"": 856,
            ""y"": 1637
          },
          {
            ""isEmpty"": false,
            ""x"": 843,
            ""y"": 1651
          },
          {
            ""isEmpty"": false,
            ""x"": 819,
            ""y"": 1622
          }
        ],
        ""words"": [
          {
            ""content"": ""te"",
            ""confidence"": 0.964,
            ""boundingPolygon"": [
              {
                ""isEmpty"": false,
                ""x"": 835,
                ""y"": 1610
              },
              {
                ""isEmpty"": false,
                ""x"": 857,
                ""y"": 1638
              },
              {
                ""isEmpty"": false,
                ""x"": 843,
                ""y"": 1650
              },
              {
                ""isEmpty"": false,
                ""x"": 819,
                ""y"": 1622
              }
            ]
          }
        ]
      }
    ]
  },
  ""cropSuggestions"": null
}");
        }


            // POST api/<PhotoController>
            [HttpPost]
        public IActionResult Post([FromForm] Photo modelPhoto)
        {

           
            try {


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

                //var path = Path.GetFullPath("C:\\home\\site\\wwwroot\\wwwroot\\Images\\test.jpg");

                using (FileStream stream = new(path, FileMode.Create))
                {
                    modelPhoto.PhotoFile.CopyTo(stream);
                    stream.Close();
                }

               
                string endPoint = "https://citizen-vision.cognitiveservices.azure.com";

                var serviceOptions = new VisionServiceOptions(endPoint, "6802e6ab7e744944b198bbc2c8f20215");

                //var imageSource = VisionSource.FromUrl($"{endPoint}/{route}/Images/{modelPhoto.PhotoName}"));


                string wwwroot = _env.WebRootPath;

                var imageSource = VisionSource.FromFile(path);

                

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

            } catch (Exception e)
            {
                return BadRequest(e);
            }
            #region test

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





            #endregion





        }




    }
}

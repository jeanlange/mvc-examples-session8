using System;
using System.Drawing;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using wednesday2.Models;

namespace wednesday2.Controllers
{
    public class HomeController : Controller
    {
        // this just pushes out a string
        public string Bleh()
        {
            return "hello";
        }

        // what other types can it do?
        // images, video, audio...
        public IActionResult GiveMeImage()
        {
            // this is a real crappy jpeg :P
            //return File(new byte[8], "image/jpeg");

            // we can read in the jpeg from a file! Manually!
            string path = "Images/spock.jpg";
            byte[] fileInfo = System.IO.File.ReadAllBytes(path);
            //return File(fileInfo, "image/jpeg");

            Bitmap image = (Bitmap)Image.FromFile("images/spock.jpg", true);
            //Image image = new Image.FromFile("images/spock.jpg"); // this line says 'fromfile' doesn't exist *shrugs*
            MemoryStream ms = new MemoryStream();

            // do something to every pixel
            for(int x = 0; x < image.Width; x++)
            {
                for(int y = 0; y < image.Height; y++)
                {
                    Color current = image.GetPixel(x, y);
                    Color newColor = Color.FromArgb(Math.Min(current.R + 50, 255), current.G, Math.Max(current.B - 50, 0));
                    image.SetPixel(x, y, newColor);
                }
            }

            image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return new FileContentResult(ms.ToArray(), "image/jpeg");
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

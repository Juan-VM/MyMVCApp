using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;
using System.Diagnostics;

namespace MyWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Hotel> hotels = new List<Hotel>();

            hotels.Add(new Hotel
            {
                Id = 1,
                Name = "Hotel Papagayo",
                Address = "Guanacaste, Costa Rica",
                Description = "",
                Photo = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/12/03/b5/12/occidental-papagayo-adults.jpg?w=900&h=-1&s=1"
            });

            hotels.Add(new Hotel
            {
                Id = 1,
                Name = "Hotel Fiesta Puntarenas",
                Address = "Puntarenas, Costa Rica",
                Description = "",
                Photo = "https://images.trvl-media.com/lodging/18000000/17770000/17763500/17763483/18e5786a.jpg"
            });

            hotels.Add(new Hotel
            {
                Id = 1,
                Name = "Hotel RUI",
                Address = "Guanacaste, Costa Rica",
                Description = "",
                Photo = "https://images.trvl-media.com/lodging/18000000/17770000/17763500/17763483/18e5786a.jpg"
            });

            //ViewBag.hotels = hotels;

            return View(hotels);
        }

        public IActionResult Privacy()
        {
            ViewData["Titulo"] = "Mi página de privacidad";
            ViewData["Año"] = 2024;
            return View();           
        }

        public IActionResult Settings()
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

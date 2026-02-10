using System.Diagnostics;
using e_Ticaret.Mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace e_Ticaret.Mvc.Controllers
{
    public class HomeController : Controller
    {



        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("about-us")]
        public IActionResult AboutUs()
        {
            return View();
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpGet("products")]
        public IActionResult Listing()
        {
            return View();
        }

        [HttpGet("testimonial")]
        public IActionResult Testimonial()
        {
            return View();
        }

        //[HttpGet("product/{categoryName}-{title}-{id:int}/details")]
        public IActionResult ProductDetail(string categoryName, string title, int id)
        {
            return View();
        }

     }
}

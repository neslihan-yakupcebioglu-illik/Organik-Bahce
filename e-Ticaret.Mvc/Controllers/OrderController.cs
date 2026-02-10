using Microsoft.AspNetCore.Mvc;

namespace e_Ticaret.Mvc.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }

        [HttpGet("order/{id:int}/details")]
        public IActionResult Details(int id)
        {
            return View();
        }
    }
}


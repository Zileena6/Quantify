using Microsoft.AspNetCore.Mvc;

namespace Quantify.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Home";

            return View();
        }
    }
}

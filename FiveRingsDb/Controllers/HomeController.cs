using Microsoft.AspNetCore.Mvc;

namespace FiveRingsDb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
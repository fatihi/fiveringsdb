using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace FiveRingsDb.Controllers
{
    public class CardsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
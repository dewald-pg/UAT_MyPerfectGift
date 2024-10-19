using Microsoft.AspNetCore.Mvc;

namespace MyPerfectGift.Controllers
{
    public class LandingController : Controller
    {
        public IActionResult Index()
        {
            return View("landing");
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Mid_Assignment.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Education()
        {
            return View();
        }

        public IActionResult Projects()
        {
            return View();
        }

        public IActionResult References()
        {
            return View();
        }
    }
}

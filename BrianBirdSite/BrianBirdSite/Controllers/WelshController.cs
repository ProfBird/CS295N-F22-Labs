using Microsoft.AspNetCore.Mvc;

namespace BrianBirdSite.Controllers
{
    public class WelshController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Consonants()
        {
            return View();
        }
    }
}

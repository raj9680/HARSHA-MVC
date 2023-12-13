using Microsoft.AspNetCore.Mvc;

namespace StatusCodeResult.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

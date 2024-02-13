using Microsoft.AspNetCore.Mvc;

namespace StronglyTypedViews.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

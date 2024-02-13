using Microsoft.AspNetCore.Mvc;

namespace StronglyTypedViews.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}

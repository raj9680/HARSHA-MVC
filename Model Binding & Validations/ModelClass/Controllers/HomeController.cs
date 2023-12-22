using Microsoft.AspNetCore.Mvc;
using ModelClass.Models;

namespace ModelClass.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return Content("Hello World", "text/plain");
        }


        [Route("bookstore/{bookid?}")] 
        // "bookstore/23?bookid=10&author=Raj"
        public IActionResult Index([FromQuery] int? bookid, BookModel bookModel) 
        // model binding creates obj auto.
        {
            return Content($"{bookModel}");
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace MVC_2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //ContentResult result = new ContentResult();
            //result.Content = "hello from index!";
            //result.ContentType = "text/html";
            //return result;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }
    }
}

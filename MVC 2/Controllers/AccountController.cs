using Microsoft.AspNetCore.Mvc;

namespace MVC_2.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}

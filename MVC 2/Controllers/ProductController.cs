using Microsoft.AspNetCore.Mvc;

namespace MVC_2.Controllers
{
    public class ProductController : Controller
    {
        public ContentResult Get(int id, string name) 
        {
            //ContentResult result = new ContentResult();
            //result.Content = $"product {id}";
            //result.ContentType = "object/pdf";
            return Content($"product {id} : {name}");
        }

        public RedirectResult Redirect()
        {
            //RedirectResult redirectResult = new RedirectResult("https://www.google.com/");
            return Redirect("https://www.google.com/");
        }

        public RedirectToActionResult RedirectToAction()
        {
            //RedirectToActionResult redirectResult = new RedirectToActionResult("Get", "Product", new{id=10});
            return RedirectToAction(nameof(Get), new {id=12}) ;
        }
    }
}

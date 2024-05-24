using HelloWorldMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            AppMessage obj = new AppMessage()
            {
                Message = "Hello World!"
            };
            return View(obj);
        }
        [HttpPost]
        public IActionResult Index(AppMessage obj)
        {
            ViewBag.Message = "Message Changed.";
            return View(obj);
        }
    }
}

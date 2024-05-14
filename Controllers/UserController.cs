using Microsoft.AspNetCore.Mvc;

namespace MVC1.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Name"] = "Nicat";
            ViewBag.Surname = "Namazov";
            ViewBag.Age = "27";
            ViewBag.Country = "Azerbaijan";
            ViewBag.PhoneNumber = "+994107179757";
            return View();
        }
    }
}

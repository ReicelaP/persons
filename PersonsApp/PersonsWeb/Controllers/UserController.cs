using Microsoft.AspNetCore.Mvc;

namespace PersonsWeb.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

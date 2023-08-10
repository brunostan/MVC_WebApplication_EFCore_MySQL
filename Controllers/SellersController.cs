using Microsoft.AspNetCore.Mvc;

namespace MVC_WebApplication.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using MVC_WebApplication.Models.ViewModels;

namespace MVC_WebApplication.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new()
            {
                new Department { Id = 1, Name = "Eletronics" },
                new Department { Id = 2, Name = "Fashion" }
            };

            return View(list);
        }
    }
}

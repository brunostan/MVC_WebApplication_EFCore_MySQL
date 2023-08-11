using MVC_WebApplication.Data;
using MVC_WebApplication.Models;

namespace MVC_WebApplication.Services
{
    public class DepartmentService
    {
        private readonly MVC_WebApplicationContext _context;

        public DepartmentService(MVC_WebApplicationContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}

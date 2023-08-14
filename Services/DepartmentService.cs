using Microsoft.EntityFrameworkCore;
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

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}

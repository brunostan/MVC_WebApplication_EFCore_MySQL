using Microsoft.EntityFrameworkCore;

namespace MVC_WebApplication.Data
{
    public class MVC_WebApplicationContext : DbContext
    {
        public MVC_WebApplicationContext(DbContextOptions<MVC_WebApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_WebApplication.Models.ViewModels.Department> Department { get; set; } = default!;
    }
}

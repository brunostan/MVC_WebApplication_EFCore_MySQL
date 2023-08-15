using Microsoft.EntityFrameworkCore;
using MVC_WebApplication.Models;

namespace MVC_WebApplication.Data
{
    public class MVC_WebApplicationContext : DbContext
    {
        public MVC_WebApplicationContext(DbContextOptions<MVC_WebApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }

    }
}

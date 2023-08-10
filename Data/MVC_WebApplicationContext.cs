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

        public DbSet<Department> Department { get; set; } = default!;
        public DbSet<Seller> Seller { get; set; } = default!;
        public DbSet<SalesRecord> SalesRecords { get; set; } = default!;

    }
}

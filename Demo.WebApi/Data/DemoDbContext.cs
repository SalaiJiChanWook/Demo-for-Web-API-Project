using Demo.WebApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Demo.WebApi.Data
{
    public class DemoDbContext : DbContext
    {
        public DemoDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Product> Products { get; set; }

    }
}

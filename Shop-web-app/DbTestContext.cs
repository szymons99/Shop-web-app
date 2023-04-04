using Microsoft.EntityFrameworkCore;
using Shop_web_app.Models;

namespace Shop_web_app
{
    public class DbTestContext : DbContext
    {
        public DbTestContext(DbContextOptions<DbTestContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}

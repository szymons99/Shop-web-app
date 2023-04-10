using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Shop_web_app.Models;

namespace Shop_web_app
{
    public class DbTestContext : IdentityDbContext<UserModel>
    {
        public DbTestContext(DbContextOptions<DbTestContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}

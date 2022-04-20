
using ApiCatalogy.Category;
using Microsoft.EntityFrameworkCore;

namespace ApiCatalogy.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options ) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Categorys> Category { get;}
    }
}

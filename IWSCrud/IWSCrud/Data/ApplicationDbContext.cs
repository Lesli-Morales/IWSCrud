using IWSCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace IWSCrud.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Item> Item { get; set; }

        public DbSet<CatalogTypes> CatalogTypes { get; set; }
    }
}

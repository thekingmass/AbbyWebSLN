using AbbyWeb.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace AbbyWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)        {
                
        }

        public DbSet<Category> Category { get; set; }
    }
}

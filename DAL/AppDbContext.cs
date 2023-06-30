using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace celilcavus.Udemy.EFCoreDatabaseFirst.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
            
        }
        public AppDbContext(DbContextOptions<AppDbContext> builder) : base(builder)
        {
                        
        }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(DbContextInitializer.configuration.GetConnectionString("sqlcon"));
        }
    }
}

using GettingStartedApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace GettingStartedApp
{
    public class MyDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(connectionString: "Server=localhost;Database=EfCoreDb;User Id=admin;Password=admin;TrustServerCertificate=True");
        }
    }
}

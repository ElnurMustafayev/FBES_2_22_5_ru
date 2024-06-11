using Microsoft.EntityFrameworkCore;
using ScroogeApp.Core.Models;

namespace ScroogeApp.Infrastructure.Data
{
    public class MyDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) {}
    }
}
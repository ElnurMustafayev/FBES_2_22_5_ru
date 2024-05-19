#pragma warning disable CS8618

using EfMvcApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EfMvcApp.Data
{
    public class MyDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) {}
    }
}
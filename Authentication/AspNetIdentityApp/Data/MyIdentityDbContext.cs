namespace AspNetIdentityApp.Data;

using AspNetIdentityApp.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class MyIdentityDbContext : IdentityDbContext<IdentityUser, IdentityRole, string>
{
    public DbSet<Product> Products { get; set; }

    public MyIdentityDbContext(DbContextOptions options) : base(options) {}
}
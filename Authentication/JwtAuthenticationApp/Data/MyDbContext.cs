using JwtAuthenticationApp.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JwtAuthenticationApp.Data
{
    public class MyDbContext : IdentityDbContext<IdentityUser, IdentityRole, string>
    {
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        public MyDbContext(DbContextOptions options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder
                .Entity<RefreshToken>()
                .HasKey(rt => rt.Token);
        }
    }
}
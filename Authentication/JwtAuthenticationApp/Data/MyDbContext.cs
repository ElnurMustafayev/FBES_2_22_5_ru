using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JwtAuthenticationApp.Data
{
    public class MyDbContext : IdentityDbContext<IdentityUser, IdentityRole, string>
    {
        public MyDbContext(DbContextOptions options) : base(options) {}
    }
}
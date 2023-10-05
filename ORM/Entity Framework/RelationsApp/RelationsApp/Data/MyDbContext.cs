namespace RelationsApp.Data;

using Microsoft.EntityFrameworkCore;
using RelationsApp.Data.Configurations;
using RelationsApp.Entities;
using RelationsApp.Entities.OneToMany;

public class MyDbContext : DbContext
{
    private const string connectionString = "Server=localhost;Database=MyDatabase;User Id=admin;Password=admin;TrustServerCertificate=True";
    public DbSet<User> Users { get; set; }
    public DbSet<Country> Countries { get; set; }

    public DbSet<Comment> Comments { get; set; }
    public DbSet<Post> Posts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(connectionString);

        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //var userTypeBuilder = modelBuilder.Entity<User>();

        //userTypeBuilder
        //    .HasKey(u => u.MyPrimaryKey);

        modelBuilder.ApplyConfiguration(new CountryConfiguration());

        modelBuilder.Entity<User>()
            .HasKey(u => u.MyPrimaryKey);

        modelBuilder.Entity<User>()
            .Property(u => u.Mail)
            .HasColumnName("EMAIL")
            .HasMaxLength(50);

        modelBuilder.Entity<User>()
            .Property(u => u.Password)
            .HasColumnName("PWD")
            .HasMaxLength(50);

        base.OnModelCreating(modelBuilder);
    }
}
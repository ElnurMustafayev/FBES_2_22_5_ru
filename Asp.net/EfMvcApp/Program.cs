using EfMvcApp.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<MyDbContext>(dbContextOptionsBuilder => {
    var connectionString = builder.Configuration.GetConnectionString("MsSqlServer");
    dbContextOptionsBuilder.UseSqlServer(connectionString);
});

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

/*
var scope = app.Services.CreateScope();
var dbContext = scope.ServiceProvider.GetRequiredService<MyDbContext>();
await dbContext.Database.MigrateAsync();
await dbContext.Database.EnsureCreatedAsync();
*/

app.Run();

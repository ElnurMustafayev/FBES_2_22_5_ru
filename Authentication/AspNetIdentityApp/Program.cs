using AspNetIdentityApp.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<MyIdentityDbContext>(dbContextBuilder => {
    var connectionString = builder.Configuration.GetConnectionString("AspNetIdentityMsSql");
    dbContextBuilder.UseSqlServer(connectionString, options => { options.EnableRetryOnFailure(5); });
});

builder.Services.AddIdentity<IdentityUser, IdentityRole>(options => {
    //options.Password.RequireDigit = true;
}).AddEntityFrameworkStores<MyIdentityDbContext>();

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

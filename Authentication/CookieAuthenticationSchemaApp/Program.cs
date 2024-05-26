#pragma warning disable ASP0025

using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Cors.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        //options.ExpireTimeSpan = TimeSpan.FromSeconds(60);
        //options.Cookie.Name = "Test";
        //options.ReturnUrlParameter = "elnur";
        options.LoginPath = "/Identity/Login";
        //options.AccessDeniedPath = "/api/Identity/Logout";
        //options.AccessDeniedPath
    });

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("MyPolicy", policyBuilder =>
    {
        policyBuilder.RequireClaim(ClaimTypes.Country);
    });

    options.AddPolicy("IT", policyBuilder =>
    {
        policyBuilder.RequireClaim(ClaimTypes.Role, "Administrator", "Developer", "QA");
    });
});

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseAuthentication();
app.UseAuthorization();

app.Run();
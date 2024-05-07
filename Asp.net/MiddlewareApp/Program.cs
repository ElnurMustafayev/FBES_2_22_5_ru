using MiddlewareApp.Middlewares;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();

app.UseMiddleware<FirstMiddleware>();
app.UseMiddleware<SecondMiddleware>();

app.MapDefaultControllerRoute();
app.Run();
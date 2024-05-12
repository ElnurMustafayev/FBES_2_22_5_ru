using MiddlewareApp.Middlewares;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddTransient<TypizedMiddleware>();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();

app.UseMiddleware<FirstMiddleware>();
app.UseMiddleware<SecondMiddleware>();
app.UseMiddleware<SaySomethingMiddleware>();
app.UseMiddleware<TypizedMiddleware>();

app.MapDefaultControllerRoute();
app.Run();
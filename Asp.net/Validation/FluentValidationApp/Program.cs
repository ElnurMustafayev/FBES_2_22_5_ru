using System.Reflection;
using FluentValidation;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.MapDefaultControllerRoute();

app.Run();

using DependencyInjectionApp.Repositories;
using DependencyInjectionApp.Repositories.Base;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

// builder.Services.AddSingleton(typeof(ProductJsonFileRepository));
// builder.Services.AddSingleton(typeof(IProductRepository), typeof(ProductJsonFileRepository));

// builder.Services.AddSingleton<ProductJsonFileRepository>();
builder.Services.AddSingleton<IProductRepository, ProductJsonFileRepository>();

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.MapDefaultControllerRoute();

app.Run();
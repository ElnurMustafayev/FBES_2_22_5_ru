using DependencyInjectionApp.Repositories;
using DependencyInjectionApp.Repositories.Base;
using DependencyInjectionApp.Services;
using DependencyInjectionApp.Services.Base;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

// builder.Services.AddSingleton(typeof(ProductJsonFileRepository));
// builder.Services.AddSingleton(typeof(IProductRepository), typeof(ProductJsonFileRepository));
// builder.Services.AddSingleton<ProductJsonFileRepository>();

//builder.Services.AddSingleton<CodeService>();
//builder.Services.AddSingleton<IProductRepository, ProductJsonFileRepository>();
//builder.Services.AddScoped<IProductRepository, ProductJsonFileRepository>();

builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddTransient<IProductRepository, ProductJsonFileRepository>();

// AddSingleton: 1 for app
// AddScoped: 1 for scope (request)
// AddTransient: 1 for injection

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.MapDefaultControllerRoute();

app.Run();
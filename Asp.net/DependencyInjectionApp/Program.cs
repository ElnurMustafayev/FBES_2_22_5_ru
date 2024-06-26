using DependencyInjectionApp.Controllers;
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


// builder.Services.AddScoped<IProductService, ProductService>();
//builder.Services.AddTransient<IProductRepository, ProductJsonFileRepository>();

builder.Services.AddTransient<IProductRepository>((serviceProvider) => {
    IProductRepository repository = RepoController.toggle
        ? new ProductJsonFileRepository()
        : new ProductSqlRepository();

    System.Console.WriteLine($"{repository.GetType().Name} ServiceProvider");

    return repository;
});

builder.Services.AddScoped<IProductService>((serviceProvider) => {
    var productRepository = serviceProvider.GetRequiredService<IProductRepository>();

    return new ProductService(productRepository);
});




// AddSingleton: 1 for app
// AddScoped: 1 for scope (request)
// AddTransient: 1 for injection

var app = builder.Build();

/*
    var scope = app.Services.CreateScope();
    var productRepository = scope.ServiceProvider.GetRequiredService<IProductRepository>();

    await productRepository.EnsureCreated();
*/

app.UseStaticFiles();

app.UseRouting();

app.MapDefaultControllerRoute();

app.Run();





// GET: /api/Product
//      JsonRepository
//      SqlRepository

// GET: /api/Repo/Toggle -> JsonRepository | SqlRepository
using ConfigurationApp.Models;
using ConfigurationApp.Options;
using ConfigurationApp.Repositories;
using ConfigurationApp.Repositories.Base;
using Microsoft.AspNetCore.Components.Forms;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

/*
    var valueFromSettings = builder.Configuration
        .GetSection("MySettings")
        .GetSection("One")
        .Get<int>();
    System.Console.WriteLine(valueFromSettings);
*/

/*
    var numbersFromSettings = builder.Configuration
        .GetSection("TestSettings")
        .GetSection("Numbers")
        .Get<int[]>();

    foreach (var number in numbersFromSettings)
    {
        System.Console.WriteLine(number);
    }
*/

/*
var testSettings = builder.Configuration
    .GetSection("TestSettings")
    .Get<TestSettings>();

System.Console.WriteLine(testSettings?.Numbers?.Count().ToString() ?? "NOTFOUND");
*/

/*
System.Console.WriteLine(builder.Configuration["MySettings:One"]);
System.Console.WriteLine(builder.Configuration["MySettings:Two"]);
System.Console.WriteLine(builder.Configuration["MySettings:Name"]);
*/

//System.Console.WriteLine(builder.Configuration["ConnectionStrings:SqlDb"]);
//System.Console.WriteLine(builder.Configuration.GetConnectionString("SqlDb"));

builder.Services.AddScoped<IProductRepository, ProductSqlRepository>();

var homePageSettingsSection = builder.Configuration.GetSection("HomePageSettings");
builder.Services.Configure<HomePageSettings>(homePageSettingsSection);

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.MapDefaultControllerRoute();

app.Run();
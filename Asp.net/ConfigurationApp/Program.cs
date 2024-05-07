using ConfigurationApp.Models;
using ConfigurationApp.Options;
using ConfigurationApp.Options.Connections;
using ConfigurationApp.Repositories;
using ConfigurationApp.Repositories.Base;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.Options;

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

/*
foreach (var environmentVariable in Environment.GetEnvironmentVariables(EnvironmentVariableTarget.Process))
{
    System.Console.WriteLine(environmentVariable);
}

System.Console.WriteLine(builder.Environment.EnvironmentName);

System.Console.WriteLine(builder.Configuration["Test:Value"]);

//builder.Configuration.Add(new JsonConfigurationSource());
if(builder.Environment.IsStaging()) {
    builder.Configuration.AddJsonFile("appsettings.Staging.json");
}

foreach (var configurationSource in builder.Configuration.Sources)
{
    if(configurationSource is JsonConfigurationSource jsonConfigurationSource) {
        System.Console.WriteLine(jsonConfigurationSource.Path);
    }
} 
*/

var msSqlConnectionSection = builder.Configuration.GetSection("Connections")
    .GetSection("MsSqlDb");

builder.Services.Configure<MsSqlConnectionOptions>(msSqlConnectionSection);

builder.Services.AddScoped<IProductRepository, ProductSqlRepository>();

var homePageSettingsSection = builder.Configuration.GetSection("HomePageSettings");
builder.Services.Configure<HomePageSettings>(homePageSettingsSection);

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.MapDefaultControllerRoute();

app.Run();
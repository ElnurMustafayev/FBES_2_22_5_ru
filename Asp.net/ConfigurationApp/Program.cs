using ConfigurationApp.Models;
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

System.Console.WriteLine(builder.Configuration["MySettings:One"]);
System.Console.WriteLine(builder.Configuration["MySettings:Two"]);
System.Console.WriteLine(builder.Configuration["MySettings:Name"]);

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.MapDefaultControllerRoute();

app.Run();
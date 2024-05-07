using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ConfigurationApp.Models;
using ConfigurationApp.Repositories.Base;
using ConfigurationApp.Options;
using Microsoft.Extensions.Options;

namespace ConfigurationApp.Controllers;

public class HomeController : Controller
{
    private static bool monitorActionRegistered = false;

    private readonly IProductRepository productRepository;
    private readonly HomePageSettings homePageSettings;

    public HomeController(IProductRepository productRepository, 
        IOptions<HomePageSettings> homePageSettingsOptions,
        IOptionsSnapshot<HomePageSettings> homePageSettingsOptionsSnapshot,
        IOptionsMonitor<HomePageSettings> homePageSettingsOptionsMonitor)
    {
        //this.homePageSettings = homePageSettingsOptions.Value;
        //this.homePageSettings = homePageSettingsOptionsSnapshot.Value;
        this.homePageSettings = homePageSettingsOptionsMonitor.CurrentValue;

        if(monitorActionRegistered == false) {
            homePageSettingsOptionsMonitor.OnChange((setting, changedValue) => {
                System.Console.WriteLine(setting.WelcomeWord);
                System.Console.WriteLine(setting.TagName);
                System.Console.WriteLine(setting.Hidden);
                System.Console.WriteLine(changedValue);
                Console.WriteLine($"HomePageSettings changed!!!");
                System.Console.WriteLine();
            });

            monitorActionRegistered = true;
        }

        this.productRepository = productRepository;
    }

    public async Task<IActionResult> Index()
    {
        base.ViewBag.Username = "Bob";
        base.ViewBag.MaxId = await this.productRepository.GetMaxIdAsync();

        return View(this.homePageSettings);
    }

    public IActionResult Privacy()
    {
        return View();
    }
}

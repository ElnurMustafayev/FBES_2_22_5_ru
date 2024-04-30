using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ConfigurationApp.Models;
using ConfigurationApp.Repositories.Base;
using ConfigurationApp.Options;
using Microsoft.Extensions.Options;

namespace ConfigurationApp.Controllers;

public class HomeController : Controller
{
    private readonly IProductRepository productRepository;
    private readonly HomePageSettings homePageSettings;

    public HomeController(IProductRepository productRepository, IOptions<HomePageSettings> homePageSettingsOptions)
    {
        this.homePageSettings = homePageSettingsOptions.Value;
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

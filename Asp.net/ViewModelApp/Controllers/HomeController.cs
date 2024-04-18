using Microsoft.AspNetCore.Mvc;

namespace ViewModelApp.Controllers;

public class HomeController : Controller
{
    public async Task<IActionResult> Index()
    {
        // base.ViewBag.Username = "Ann";
        // base.ViewData["name"] = "John";

        return base.View();
    }
}
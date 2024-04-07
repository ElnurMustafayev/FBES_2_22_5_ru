using Microsoft.AspNetCore.Mvc;

namespace MvcApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult GetRandomUsername() {
        return View();
    }
}

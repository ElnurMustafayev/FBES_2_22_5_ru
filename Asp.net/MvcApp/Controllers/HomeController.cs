using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcApp.Models;

namespace MvcApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return base.View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult GetRandomUsername() {
        return View();
    }
}

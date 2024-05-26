using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CookieAuthenticationSchemaApp.Models;
using Microsoft.AspNetCore.Authorization;

namespace CookieAuthenticationSchemaApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    //[Authorize]
    [Authorize("IT")]
    public IActionResult Secret() {
        return View();
    }
}
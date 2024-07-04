namespace AspNetIdentityApp.Controllers;

using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{

    public HomeController()
    {
    }

    public IActionResult Index()
    {
        System.Console.WriteLine(base.User.Identity.Name);
        
        foreach (var claim in base.User.Claims)
        {
            System.Console.WriteLine($"{claim.Type}: {claim.Value}");
        }
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
}

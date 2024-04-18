namespace ViewModelApp.Controllers;

using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using ViewModelApp.Models;

[Route("/[controller]/[action]")]
public class UserController : Controller
{
    [ActionName("Info")]
    public async Task<IActionResult> GetUserAsync() {
        var userJson = await System.IO.File.ReadAllTextAsync("./Asserts/user.json");

        var user = JsonSerializer.Deserialize<User>(userJson);

        //base.ViewBag.User = user;
        //base.ViewData["user"] = user;

        return base.View(model: user);
    }
}
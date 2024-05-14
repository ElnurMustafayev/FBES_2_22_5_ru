using Microsoft.AspNetCore.Mvc;
using TagHelpersApp.Models;

namespace TagHelpersApp.Controllers;

public class UserController : Controller
{
    private static List<User> Users { get; set; }

    static UserController() {
        Users = new List<User> {
            new User(Guid.NewGuid(), "Bob", "Marley"),
            new User(Guid.NewGuid(), "Ann", "Brown"),
            new User(Guid.NewGuid(), "Jane", "White"),
        };
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Create() {
        return View();
    }

    [HttpPost("/api/[controller]")]
    public IActionResult CreateNewUser([FromForm]User newUser) {
        if(string.IsNullOrWhiteSpace(newUser.Name) || string.IsNullOrWhiteSpace(newUser.Surname)) {
            return base.BadRequest(new {
                Message = "Name or Surname is empty!"
            });
        }

        newUser.Uid = Guid.NewGuid();
        Users.Add(newUser);

        return base.RedirectToAction(actionName: "All");
    }

    [Route("/api/[controller]/[action]")]
    [ActionName("All")]
    public IEnumerable<User> GetUsers() {
        return Users;
    }
}
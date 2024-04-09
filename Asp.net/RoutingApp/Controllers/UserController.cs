// GET: /User
// POST: /User
// DELETE: /User
// PUT: /User


namespace RoutingApp.Controllers;

using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using RoutingApp.Models;

public class UserController : Controller
{
    // GET: /User
    [HttpGet]
    [Route("[controller]")]
    public IActionResult Index() {
        return View();
    }

    /*
    // GET: /User
    // /User/GetAllUsersAsync
    // [ActionName("GetAllUsersAsync")]
    // [Route("[controller]/[action]/[controller]")]
    [HttpGet]
    [Route("[controller]")]
    public async Task<IActionResult> GetAllUsersAsync() {
        var usersJson = await System.IO.File.ReadAllTextAsync("Assets/users.json");

        var users = JsonSerializer.Deserialize<IEnumerable<User>>(usersJson, new JsonSerializerOptions {
            PropertyNameCaseInsensitive = true,
        });

        return Ok(users);
    }
    */

    [HttpGet]
    [ActionName("byname")]

    // GET: /User/byname?name={"bob"}
    //[Route("[controller]/[action]")]

    // GET: /User/byname/{"bob"}
    [Route("[controller]/[action]/{name}")]
    public IActionResult GetUserByName(string name) {
        return Ok($"TEST ROUTING: {name}");
    }

    // POST: /User
    [HttpPost]
    [Route("[controller]")]
    public async Task<IActionResult> CreateNewUser(User newUser) {
        var usersJson = await System.IO.File.ReadAllTextAsync("Assets/users.json");

        var users = JsonSerializer.Deserialize<List<User>>(usersJson, new JsonSerializerOptions {
            PropertyNameCaseInsensitive = true,
        });

        users?.Add(newUser);

        var resultUsersJson = JsonSerializer.Serialize<List<User>>(users, new JsonSerializerOptions {
            PropertyNameCaseInsensitive = true,
        });

        await System.IO.File.WriteAllTextAsync("Assets/users.json", resultUsersJson);

        return base.RedirectToAction(actionName: "Index");
        //return base.View("Index");
    }
}
using System.Text.Json;
using FilesApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilesApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        [Route("[action]", Name = "UserCreateView")]
        public IActionResult Create() {
            return base.View();
        }


        [HttpPost]
        [Route("/api/[controller]/[action]", Name = "CreateNewUser")]
        public async Task<IActionResult> Create([FromForm]User newUser, IFormFile avatar) {
            newUser.Id = Guid.NewGuid();

            var extension = new FileInfo(avatar.FileName).Extension[1..];

            using var newFileStream = System.IO.File.Create($"Assets/Avatars/{newUser.Id}.{extension}");
            await avatar.CopyToAsync(newFileStream);

            var allUsersJson = System.IO.File.ReadAllText("Assets/users.json");
            var allUsers = JsonSerializer.Deserialize<IEnumerable<User>>(allUsersJson);
            allUsers = allUsers?.Append(newUser);
            var allUsersWithNewUserJson = JsonSerializer.Serialize(allUsers);
            System.IO.File.WriteAllText("Assets/users.json", allUsersWithNewUserJson);

            return base.RedirectToRoute("UserCreateView");
        }
    }
}
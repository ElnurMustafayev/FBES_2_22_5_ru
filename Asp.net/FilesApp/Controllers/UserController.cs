using System.Text.Json;
using FilesApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilesApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        [Route("{guid}")]
        public IActionResult Index(Guid guid) {
            var allUsersJson = System.IO.File.ReadAllText("Assets/users.json");
            var allUsers = JsonSerializer.Deserialize<IEnumerable<User>>(allUsersJson);
            var foundUser = allUsers.First(user => user.Id == guid);

            return View(foundUser);
        }

        [Route("[action]", Name = "UserCreateView")]
        public IActionResult Create() {
            return base.View();
        }

        [HttpPost]
        [Route("/api/[controller]/[action]", Name = "CreateNewUser")]
        public async Task<IActionResult> Create([FromForm]User newUser, IFormFile avatar) {
            newUser.Id = Guid.NewGuid();

            var extension = new FileInfo(avatar.FileName).Extension[1..];
            newUser.AvatarPath = $"Assets/Avatars/{newUser.Id}.{extension}";

            using var newFileStream = System.IO.File.Create(newUser.AvatarPath);
            await avatar.CopyToAsync(newFileStream);

            var allUsersJson = System.IO.File.ReadAllText("Assets/users.json");
            var allUsers = JsonSerializer.Deserialize<IEnumerable<User>>(allUsersJson);
            var allUsersWithNewUserJson = JsonSerializer.Serialize(allUsers?.Append(newUser));
            System.IO.File.WriteAllText("Assets/users.json", allUsersWithNewUserJson);

            return base.RedirectToRoute("UserCreateView");
        }
    
        [HttpGet("[action]/{guid}")]
        public async Task<IActionResult> Avatar(Guid guid) {
            var allUsersJson = System.IO.File.ReadAllText("Assets/users.json");
            var allUsers = JsonSerializer.Deserialize<IEnumerable<User>>(allUsersJson);
            var foundUser = allUsers.First(user => user.Id == guid);

            var fileStream = System.IO.File.Open(foundUser.AvatarPath, FileMode.Open);
            return base.File(fileStream, "image/jpeg");
        }
    }
}
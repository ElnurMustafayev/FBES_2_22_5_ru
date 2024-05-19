using EfMvcApp.Data;
using EfMvcApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace EfMvcApp.Controllers
{
    [Route("[controller]/[action]")]
    public class UserController : Controller
    {
        private string[] names = {"Ann", "Bob", "Kate"};
        private string[] surnames = {"Marley", "Brown", "Black"};
        private readonly MyDbContext context;

        public UserController(MyDbContext context)
        {
            this.context = context;
        }

        [ActionName("Generate")]
        public async Task<IActionResult> GenerateNewUserAsync() {
            var newUser = new User {
                Name = names[Random.Shared.Next(names.Length)],
                Surname = surnames[Random.Shared.Next(names.Length)],
                AvatarPath = null,
            };

            await context.Users.AddAsync(newUser);
            await context.SaveChangesAsync();

            return base.Ok();
        }
    }
}
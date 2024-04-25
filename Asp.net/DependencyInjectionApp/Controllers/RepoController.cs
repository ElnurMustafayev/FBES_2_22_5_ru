using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionApp.Controllers;

[Route("api/[controller]/[action]")]
public class RepoController : Controller
{
    public static bool toggle { get; set; }
    public IActionResult Toggle() {
        toggle = !toggle;

        return Ok(toggle);
    }
}
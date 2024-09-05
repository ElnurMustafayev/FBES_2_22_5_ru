namespace WebApi1.Controllers;

using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("/api/[controller]/[action]")]
public class UsersController : ControllerBase
{
    [HttpGet("/api/[controller]/All")]
    public IActionResult GetAllUsers() {
        return Ok(WebApi2.BackgroudServices.PullNewUsersRabbitMqService.Users);
    }
}
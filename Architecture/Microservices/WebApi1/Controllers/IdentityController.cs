namespace WebApi1.Controllers;

using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;
using WebApi1.Entities;
using WebApi1.Services.Base;

[ApiController]
[Route("/api/[controller]/[action]")]
public class IdentityController : ControllerBase
{
    private readonly IUserService userService;
    private readonly IMessageBrokerService messageBroker;

    public IdentityController(IUserService userService, IMessageBrokerService messageBroker)
    {
        this.userService = userService;
        this.messageBroker = messageBroker;
    }

    [HttpPost]
    public async Task<IActionResult> SignUp(User newUser) {
        var userId = await this.userService.SignUp(newUser);

        _ = this.messageBroker.Push("new_user", new {
            Id = userId,
            BirthDate = newUser.BirthDate,
            Email = newUser.Email,
            Name = newUser.Name,
            Surname = newUser.Surname,
        });

        return Ok();
    }
}
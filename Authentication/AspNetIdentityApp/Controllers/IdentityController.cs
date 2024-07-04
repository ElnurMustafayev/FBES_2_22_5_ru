namespace AspNetIdentityApp.Controllers;

using AspNetIdentityApp.Dtos;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

[Route("[controller]/[action]")]
public class IdentityController : Controller
{
    private readonly SignInManager<IdentityUser> signInManager;
    private readonly UserManager<IdentityUser> userManager;
    private readonly RoleManager<IdentityRole> roleManager;

    public IdentityController(
        SignInManager<IdentityUser> signInManager, 
        UserManager<IdentityUser> userManager,
        RoleManager<IdentityRole> roleManager)
    {
        this.signInManager = signInManager;
        this.userManager = userManager;
        this.roleManager = roleManager;
    }

    [Route("[controller]/[action]", Name = "LoginView")]
    public IActionResult Login() {
        return this.View();
    }

    [HttpPost]
    [Route("/api/[controller]/[action]", Name = "LoginEndpoint")]
    public async Task<IActionResult> Login([FromForm] LoginDto dto) {
        var user = await this.userManager.FindByEmailAsync(dto.Login);

        // await roleManager.CreateAsync(new IdentityRole() {
        //     Name = "admin",
        // });

        //userManager.GetRolesAsync(user);
        //userManager.AddToRoleAsync(user, "admin");
        //userManager.IsInRoleAsync(user, "admin");
        //userManager.RemoveFromRoleAsync(user, "admin");

        

        if(user == null) {
            return base.BadRequest("Incorrect email or password!");
        }

        // await roleManager.CreateAsync(new IdentityRole() {
        //     Name = "admin",
        // });

        // await userManager.AddToRoleAsync(user, "admin");

        var result = await this.signInManager.PasswordSignInAsync(user, dto.Password, true, true);

        return result.Succeeded
            ? base.RedirectToAction(actionName: "Index", controllerName: "Home")
            : base.BadRequest("Incorrect email or password");
    }

    [Route("[controller]/[action]", Name = "RegistrationView")]
    public IActionResult Registration() {
        return this.View();
    }

    [HttpPost]
    [Route("/api/[controller]/[action]", Name = "RegistrationEndpoint")]
    public async Task<IActionResult> Registration([FromForm] RegistrationDto dto) {
        var result = await userManager.CreateAsync(new IdentityUser() {
            Email = dto.Email,
            UserName = dto.Name,
        }, dto.Password);

        return result.Succeeded
            ? base.RedirectToAction(actionName: "Login", controllerName: "Identity")
            : base.BadRequest(string.Join("\n", result.Errors.Select(error => error.Description)));
    }

    [HttpGet]
    [Route("/api/[controller]/[action]", Name = "LogoutEndpoint")]
    public async Task<IActionResult> Logout() {
        await this.signInManager.SignOutAsync();

        return base.RedirectToAction(actionName: "Index", controllerName: "Home");
    }
}
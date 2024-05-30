using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace CookieAuthenticationSchemaApp.Controllers;

//[Authorize("MyPolicyWithRoles")]
[Authorize(Roles = "TestRole")]
public class HomeController : Controller
{
    [AllowAnonymous]
    public IActionResult Index()
    {
        return View();
    }

    //[Authorize]
    //[Authorize("IT")]
    //[Authorize("MyPolicyWithRoles")]

    // TestRole && Admin
    // [Authorize(Roles = "TestRole")]
    // [Authorize(Roles = "Admin")]

    // TestRole || Admin
    //[Authorize(Roles = "TestRole, Admin")]
    public IActionResult Secret() {
        return View();
    }
}
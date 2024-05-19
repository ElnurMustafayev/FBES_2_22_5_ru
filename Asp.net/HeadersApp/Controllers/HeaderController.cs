using Microsoft.AspNetCore.Mvc;

namespace HeadersApp.Controllers;

[Route("api/[controller]/[action]")]
public class HeaderController : ControllerBase
{
    public IActionResult TestCreated() => base.Created(base.Url.Action(), null);
    public IActionResult TestRedirect() => base.Redirect("/Test");

    [ActionName("All")]
    public IActionResult Headers() {
        base.HttpContext.Request.Headers.Add("mykey", "MyRequestValue");
        base.HttpContext.Response.Headers.Add("mykey", "MyResponseValue");

        return Ok();
    }
}
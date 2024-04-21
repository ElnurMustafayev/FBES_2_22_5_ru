namespace RoutingApp.Controllers;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using RoutingApp.Models;

[Route("api/[controller]/[action]")]
public class TestController : Controller
{
    [ActionName("RoutingEndpoint")]
    [Route("/test/[controller]/[action]/{priority:int}/{error?}", Name = "MyRouting")]
    public IActionResult Method(int priority, string? error) {
        // ...

        //base.HttpContext.Response.StatusCode = 500;
        //base.HttpContext.Response.ContentType = "application/json";

        //return base.BadRequest();
        return base.BadRequest(new MyError(error ?? "UNKNOWN", nameof(ArgumentNullException)) {
            Priority = priority,
        });
    }

    public string GenerateUrl() {
        var url = base.Url.Link(routeName: "MyRouting", 
            new {
                priority = 123,
                error = "MyError"
            });
        return url ?? "UNKNOWN";
    }
}
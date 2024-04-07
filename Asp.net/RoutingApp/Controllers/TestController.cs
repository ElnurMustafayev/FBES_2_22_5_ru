namespace RoutingApp.Controllers;

using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using RoutingApp.Models;

public class TestController : Controller
{
    public IActionResult Method() {
        // ...

        //base.HttpContext.Response.StatusCode = 500;
        //base.HttpContext.Response.ContentType = "application/json";

        //return base.BadRequest();
        return base.BadRequest(new MyError("General", nameof(ArgumentNullException)) {
            Priority = 800,
        });
    }
}
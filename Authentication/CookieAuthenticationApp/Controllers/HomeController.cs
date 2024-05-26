using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CookieAuthenticationApp.Models;
using System.Data.SqlClient;
using Dapper;
using Microsoft.AspNetCore.DataProtection;

namespace CookieAuthenticationApp.Controllers;

public class HomeController : Controller
{
    private readonly IDataProtector dataProtector;
    private readonly string identityConnectionString;
    public HomeController(IConfiguration configuration, IDataProtectionProvider dataProtectionProvider)
    {
        identityConnectionString = configuration.GetConnectionString("Identity") ?? throw new ArgumentNullException("Identity connection string");
        this.dataProtector = dataProtectionProvider.CreateProtector("identity");
    }

    public async Task<IActionResult> Index()
    {
        var authenticationHashedValue = base.HttpContext.Request.Cookies["Authentication"];

        if(string.IsNullOrWhiteSpace(authenticationHashedValue) == false) {
            var authenticationValue = this.dataProtector.Unprotect(authenticationHashedValue);

            if(long.TryParse(authenticationValue, out long userId)) {
                var connection = new SqlConnection(identityConnectionString);

                var foundUser = await connection.QueryFirstOrDefaultAsync<User>(
                    sql: "select * from Users where [Id] = @Id",
                    param: new {
                        Id = userId
                    }
                );

                return View(foundUser);
            }
        }

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

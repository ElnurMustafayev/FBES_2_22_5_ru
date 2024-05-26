using System.Data.SqlClient;
using System.Security.Claims;
using CookieAuthenticationSchemaApp.Dtos;
using CookieAuthenticationSchemaApp.Models;
using Dapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;

namespace CookieAuthenticationSchemaApp.Controllers
{
    public class IdentityController : Controller
    {
        private readonly IDataProtector dataProtector;
        private readonly string identityConnectionString;
        public IdentityController(IConfiguration configuration, IDataProtectionProvider dataProtectionProvider)
        {
            this.identityConnectionString = configuration.GetConnectionString("Identity") ?? throw new ArgumentNullException("Identity connection string");
            this.dataProtector = dataProtectionProvider.CreateProtector("identity");
        }
        
        [Route("/[controller]/[action]", Name = "LoginView")]
        public IActionResult Login() {
            var errorMessage = base.TempData["error"];
            if(errorMessage != null) {
                base.ModelState.AddModelError("All", errorMessage.ToString()!);
            }

            return base.View();
        }

        [HttpPost]
        [Route("/api/[controller]/[action]", Name = "LoginEndpoint")]
        public async Task<IActionResult> Login([FromForm]LoginDto loginDto) {
            var connection = new SqlConnection(this.identityConnectionString);
            var foundUser = await connection.QueryFirstOrDefaultAsync<User>(
                sql: "select * from Users where [Email] = @Login and [Password] = @Password",
                param: loginDto
            );

            if(foundUser == null) {
                base.TempData["error"] = "Incorrect login or password!";
                return base.RedirectToRoute("LoginView");
            }

            var claims = new Claim[] {
                new(ClaimTypes.Email, foundUser.Email),
                new(ClaimTypes.Name, foundUser.Name),
                new("id", foundUser.Id.ToString()),
            };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

            await base.HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal);

            return base.RedirectToAction(controllerName: "Home", actionName: "Index");
        }

        [Route("/[controller]/[action]", Name = "RegistrationView")]
        public IActionResult Registration() {
            if(TempData["error"] != null) {
                ModelState.AddModelError("All", "Something went wrong. Please try again");
            }

            return base.View();
        }

        [HttpPost]
        [Route("/api/[controller]/[action]", Name = "RegistrationEndpoint")]
        public async Task<IActionResult> Registration([FromForm]RegistrationDto registrationDto) {
            try {
                var connection = new SqlConnection(this.identityConnectionString);
                await connection.ExecuteAsync(
                    sql: "insert into Users([Name], [Email], [Password]) values(@Name, @Email, @Password)",
                    param: registrationDto
                );
            }
            catch(Exception ex) {
                TempData["error"] = ex.Message;
                return base.RedirectToRoute("RegistrationView");
            }

            return base.RedirectToRoute("LoginView");
        }
    
        [HttpGet]
        [Route("/api/[controller]/[action]")]
        public async Task<IActionResult> Logout() {
            base.HttpContext.Response.Cookies.Delete("Authentication");

            return base.RedirectToRoute("LoginView");
        }
    }
}
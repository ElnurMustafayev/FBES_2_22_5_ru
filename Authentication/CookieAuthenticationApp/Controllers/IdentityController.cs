using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO.Pipes;
using System.Linq;
using System.Threading.Tasks;
using CookieAuthenticationApp.Dtos;
using CookieAuthenticationApp.Models;
using Dapper;
using Microsoft.AspNetCore.Mvc;

namespace CookieAuthenticationApp.Controllers
{
    public class IdentityController : Controller
    {
        private readonly string identityConnectionString;
        public IdentityController(IConfiguration configuration)
        {
            identityConnectionString = configuration.GetConnectionString("Identity") ?? throw new ArgumentNullException("Identity connection string");
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

            base.HttpContext.Response.Headers.Add("Authentication", foundUser.Id.ToString());

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
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ScroogeApp.Core.Exceptions;
using ScroogeApp.Core.Models;
using ScroogeApp.Core.Services;
using ScroogeApp.Presentation.Dtos;

namespace ScroogeApp.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;
        public UserController(IUserService userService)
        {
            this.userService = userService;
            
        }

        [HttpGet("{username}")]
        public async Task<IActionResult> GetUserByName(string username) {
            try {
                var user = await this.userService.GetUserAsync(username);

                return base.Ok(user);
            }
            catch (NotFoundException ex) {
                return base.NotFound(ex.Message);
            }
            catch (Exception) {
                return base.StatusCode(500);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(UserDto dto) {
            var newUser = new User {
                Name = dto.Name,
                Money = dto.Money,
                IsInEmbargo = dto.IsInEmbargo,
            };

            await this.userService.CreateUserAsync(newUser);

            return base.Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetOutOfEmbargoInRange(long fromId, long toId) {
            var users = await this.userService.GetUsersOutOfEmbargo(fromId, toId);

            return base.Ok(users);
        }
    }
}
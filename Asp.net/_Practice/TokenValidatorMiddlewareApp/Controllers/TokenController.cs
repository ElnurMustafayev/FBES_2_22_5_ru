using Microsoft.AspNetCore.Mvc;
using TokenValidatorMiddlewareApp.Exceptions;
using TokenValidatorMiddlewareApp.Services;

namespace TokenValidatorMiddlewareApp.Controllers;

[Route("api/[controller]")]
public class TokenController : ControllerBase
{
    private readonly TokenService tokenService;

    public TokenController(TokenService tokenService)
    {
        this.tokenService = tokenService;
    }

    [HttpGet]
    [Route("All")]
    // /api/Token/All
    public async Task<ActionResult> GetTokensAsync() {
        try {
            var tokens = await this.tokenService.GetAllTokensAsync();

            return base.Ok(tokens);
        }
        catch(Exception) {
            return base.StatusCode(500);
        }
    }

    [HttpGet]
    [Route("Exist/{token}")]
    // /api/Token/Exist/qwqg123sd
    public async Task<ActionResult> IsTokenExistAsync(string token) {
        try {
            var isTokenExist = await this.tokenService.IsTokenExistAsync(token);

            if(!isTokenExist) {
                return base.NotFound();
            }

            return Ok();
        }
        catch(Exception) {
            return base.StatusCode(500);
        }
    }

    [HttpGet]
    [Route("{token}")]
    // /api/Token/qwqg123sd
    public async Task<ActionResult> GetTokenAsync(string token) {
        try {
            var foundToken = await this.tokenService.GetTokenAsync(token);
            return Ok(foundToken);
        }
        catch(NotFoundException ex) {
            return base.NotFound(ex.Message);
        }
        catch(Exception) {
            return base.StatusCode(500);
        }
    }
}
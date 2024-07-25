namespace JwtAuthenticationApp.Controllers;

using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using JwtAuthenticationApp.Dtos;
using JwtAuthenticationApp.Models;
using JwtAuthenticationApp.Options;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

[ApiController]
[Route("/api/[controller]/[action]")]
public class IdentityController : ControllerBase
{
    private readonly JwtOptions jwtOptions;
    private readonly UserManager<IdentityUser> userManager;
    private readonly SignInManager<IdentityUser> signInManager;
    private readonly RoleManager<IdentityRole> roleManager;

    public IdentityController(
        IOptionsSnapshot<JwtOptions> jwtOptionsSnapshot,
        UserManager<IdentityUser> userManager,
        SignInManager<IdentityUser> signInManager,
        RoleManager<IdentityRole> roleManager
        )
    {
        this.jwtOptions = jwtOptionsSnapshot.Value;
        this.userManager = userManager;
        this.signInManager = signInManager;
        this.roleManager = roleManager;
    }

    [HttpPost]
    public async Task<IActionResult> Login(LoginDto dto) {
        var foundUser = await userManager.FindByEmailAsync(dto.Login);

        if(foundUser == null) {
            return base.BadRequest("Incorrect Login or Password");
        }

        var signInResult = await this.signInManager.PasswordSignInAsync(foundUser, dto.Password, true, true);

        if(signInResult.IsLockedOut) {
            return base.BadRequest("User locked");
        }

        if(signInResult.Succeeded == false) {
            return base.BadRequest("Incorrect Login or Password");
        }

        var roles = await userManager.GetRolesAsync(foundUser);

        var claims = roles
            .Select(roleStr => new Claim(ClaimTypes.Role, roleStr))
            .Append(new Claim(ClaimTypes.NameIdentifier, foundUser.Id))
            .Append(new Claim(ClaimTypes.Email, foundUser.Email ?? "not set"))
            .Append(new Claim(ClaimTypes.Name, foundUser.UserName ?? "not set"));

        var signingKey = new SymmetricSecurityKey(jwtOptions.KeyInBytes);
        var signingCredentials = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            issuer: jwtOptions.Issuer,
            audience: jwtOptions.Audience,
            claims: claims,
            //notBefore: DateTime.Now.AddMinutes(2),
            //expires: DateTime.Now.AddMinutes(jwtOptions.LifeTimeInMinutes),
            expires: DateTime.Now.AddSeconds(10),
            signingCredentials: signingCredentials
        );

        var handler = new JwtSecurityTokenHandler();
        var tokenStr = handler.WriteToken(token);

        return Ok(tokenStr);
    } 

    [HttpPost]
    public async Task<IActionResult> Registration(RegistrationDto dto) {
        var newUser = new IdentityUser() {
            Email = dto.Email,
            UserName = dto.Username,
        };

        var result = await userManager.CreateAsync(newUser, dto.Password);

        if(result.Succeeded == false) {
            return base.BadRequest(result.Errors);
        }

        await userManager.AddToRoleAsync(newUser, UserRoleDefaults.User);

        return Ok();
    }
    
    [HttpPut]
    [ActionName("Token")]
    public async Task<IActionResult> UpdateToken() {
        var tokenStr = base.HttpContext.Request.Headers.Authorization.FirstOrDefault();

        if(tokenStr is null) {
            return base.StatusCode(401);
        }

        if(tokenStr.StartsWith("Bearer ")) {
            tokenStr = tokenStr.Substring("Bearer ".Length);
            System.Console.WriteLine(tokenStr);
        }

        var handler = new JwtSecurityTokenHandler();
        var tokenValidationResult = await handler.ValidateTokenAsync(
            tokenStr,
            new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidIssuer = "MyApplication",

                ValidateAudience = true,
                ValidAudience = "Big Company",

                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(jwtOptions.KeyInBytes)
            }
        );

        if(tokenValidationResult.IsValid == false) {
            return BadRequest(tokenValidationResult.Exception);
        }

        var token = handler.ReadJwtToken(tokenStr);

        Claim? idClaim = token.Claims.FirstOrDefault(claim => claim.Type == ClaimTypes.NameIdentifier);

        if(idClaim is null) {
            return BadRequest($"Token has no claim with type '{ClaimTypes.NameIdentifier}'");
        }

        var userId = idClaim.Value;

        IdentityUser? foundUser = await this.userManager.FindByIdAsync(userId);

        if(foundUser is null) {
            return BadRequest($"User not found by id: '{userId}'");
        }

        var roles = await userManager.GetRolesAsync(foundUser);
        
        var claims = roles
            .Select(roleStr => new Claim(ClaimTypes.Role, roleStr))
            .Append(new Claim(ClaimTypes.NameIdentifier, foundUser.Id))
            .Append(new Claim(ClaimTypes.Email, foundUser.Email ?? "not set"))
            .Append(new Claim(ClaimTypes.Name, foundUser.UserName ?? "not set"));

        var signingKey = new SymmetricSecurityKey(jwtOptions.KeyInBytes);
        var signingCredentials = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256);

        var newToken = new JwtSecurityToken(
            issuer: jwtOptions.Issuer,
            audience: jwtOptions.Audience,
            claims: claims,
            //notBefore: DateTime.Now.AddMinutes(2),
            //expires: DateTime.Now.AddMinutes(jwtOptions.LifeTimeInMinutes),
            expires: DateTime.Now.AddSeconds(10),
            signingCredentials: signingCredentials
        );

        var newTokenStr = handler.WriteToken(newToken);

        return Ok(newTokenStr);
    }

}
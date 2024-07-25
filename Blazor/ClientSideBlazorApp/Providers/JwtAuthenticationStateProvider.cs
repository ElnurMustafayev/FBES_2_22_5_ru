using System.IdentityModel.Tokens.Jwt;
using System.Net.Http.Json;
using System.Security.Claims;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.IdentityModel.Tokens;

namespace ClientSideBlazorApp.Providers;

public class JwtAuthenticationStateProvider : AuthenticationStateProvider
{
    private readonly ILocalStorageService localStorageService;
    private readonly IHttpClientFactory httpClientFactory;
    private readonly JwtSecurityTokenHandler jwtSecurityTokenHandler;

    public JwtAuthenticationStateProvider(
        ILocalStorageService localStorageService,
        IHttpClientFactory httpClientFactory)
    {
        this.localStorageService = localStorageService;
        this.httpClientFactory = httpClientFactory;
        this.jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
    }

    private async Task<ClaimsIdentity?> GetClaimsIdentity() {
        var jwt = await this.localStorageService.GetItemAsync<string>("jwt");
        if(string.IsNullOrWhiteSpace(jwt))
            return null;

        var result = await this.jwtSecurityTokenHandler.ValidateTokenAsync(
            jwt, 
            new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidIssuer = "MyApplication",

                ValidateAudience = true,
                ValidAudience = "Big Company",

                SignatureValidator = (token, validationParameters) => new JwtSecurityToken(token),

                RequireExpirationTime = true,
                ValidateLifetime = true,

                LifetimeValidator = (notBefore, expires, securityToken, validationParameters) => expires > DateTime.UtcNow,
            });

        if(result.IsValid == false) {
            Console.WriteLine("Token error: " + result.Exception.Message);
            if(result.Exception is SecurityTokenInvalidLifetimeException) {
                var identityServiceHttpClient = httpClientFactory.CreateClient("IdentityService");
                identityServiceHttpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {jwt}");
                var httpResult = await identityServiceHttpClient.PutAsync("/api/Identity/Token", null);

                if(httpResult.IsSuccessStatusCode == false) {
                    System.Console.WriteLine("Update Token error: " + await httpResult.Content.ReadAsStringAsync());
                    return null;
                }
                
                var newToken = await httpResult.Content.ReadAsStringAsync();
                await this.localStorageService.SetItemAsStringAsync("jwt", newToken);

                var newTokenObj = this.jwtSecurityTokenHandler.ReadJwtToken(jwt);
                return new ClaimsIdentity(newTokenObj.Claims, "jwt");
            }

            return null;
        }

        var tokenObj = this.jwtSecurityTokenHandler.ReadJwtToken(jwt);

        return new ClaimsIdentity(tokenObj.Claims, "jwt");
    }

    public override async Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        var claimsIdentity = await GetClaimsIdentity();

        var claimsPrincipal = claimsIdentity == null 
            ? new ClaimsPrincipal()
            : new ClaimsPrincipal(claimsIdentity);

        var authenticationState = new AuthenticationState(claimsPrincipal);

        return authenticationState;
    }
}
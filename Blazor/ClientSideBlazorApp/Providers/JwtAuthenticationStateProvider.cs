using System.IdentityModel.Tokens.Jwt;
using System.Net.Http.Json;
using System.Security.Claims;
using Blazored.LocalStorage;
using ClientSideBlazorApp.Models;
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
        var jwt = await this.localStorageService.GetItemAsStringAsync("jwt");
        var refresh = await this.localStorageService.GetItemAsStringAsync("refresh");
        if(string.IsNullOrWhiteSpace(jwt) || string.IsNullOrWhiteSpace(refresh))
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
            if(result.Exception is SecurityTokenInvalidLifetimeException) {
                var identityServiceHttpClient = httpClientFactory.CreateClient("IdentityService");
                identityServiceHttpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {jwt}");
                var httpResult = await identityServiceHttpClient.PutAsync($"/api/Identity/Token?refresh={refresh}", null);

                if(httpResult.IsSuccessStatusCode == false) {
                    return null;
                }
                
                var refreshAccessTokens = await httpResult.Content.ReadFromJsonAsync<RefreshAccessTokens>();

                if(refreshAccessTokens is null) {
                    return null;
                }
                
                await this.localStorageService.SetItemAsStringAsync("jwt", refreshAccessTokens.Access);
                await this.localStorageService.SetItemAsStringAsync("refresh", refreshAccessTokens.Refresh);

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
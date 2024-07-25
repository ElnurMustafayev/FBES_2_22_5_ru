using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ClientSideBlazorApp;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using ClientSideBlazorApp.Providers;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped<AuthenticationStateProvider, JwtAuthenticationStateProvider>();
builder.Services.AddAuthorizationCore(options =>  {
    //options.AddPolicy()
});

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddHttpClient("IdentityService", httpClient =>
{
    httpClient.BaseAddress = new Uri("http://localhost:5066/");
});
builder.Services.AddBlazoredLocalStorageAsSingleton();

await builder.Build().RunAsync();
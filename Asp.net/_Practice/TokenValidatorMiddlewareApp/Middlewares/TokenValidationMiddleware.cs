using TokenValidatorMiddlewareApp.Services;

namespace TokenValidatorMiddlewareApp.Middlewares;

public class TokenValidationMiddleware
{
    private readonly RequestDelegate next;

    public TokenValidationMiddleware(RequestDelegate next)
    {
        this.next = next;
    }

    public async Task InvokeAsync(HttpContext httpContext, TokenService tokenService) {
        var tokenQueryParameterValues = httpContext.Request.Query["token"];

        if(tokenQueryParameterValues.Any() == false) {
            httpContext.Response.StatusCode = 401;
            return;
        }

        var tokenStr = tokenQueryParameterValues.First();

        if(string.IsNullOrWhiteSpace(tokenStr) || await tokenService.IsTokenExistAsync(tokenStr) == false) {
            httpContext.Response.StatusCode = 401;
            return;
        }

        await next.Invoke(httpContext);
    }
}
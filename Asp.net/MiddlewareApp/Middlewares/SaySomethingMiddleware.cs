namespace MiddlewareApp.Middlewares;

public class SaySomethingMiddleware
{
    private readonly RequestDelegate next;
    public SaySomethingMiddleware(RequestDelegate next)
    {
        this.next = next;
    }

    public async Task InvokeAsync(HttpContext httpContext, IConfiguration configuration) {
        var whatToSay = configuration["MiddlewareSettings:Say"];

        if(string.IsNullOrWhiteSpace(whatToSay) == false) {
            System.Console.WriteLine($"Middleware: '{whatToSay}'");
        }
        
        await this.next.Invoke(httpContext);
    }
}
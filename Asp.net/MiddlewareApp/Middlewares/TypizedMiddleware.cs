namespace MiddlewareApp.Middlewares;

public class TypizedMiddleware : IMiddleware
{
    private readonly IConfiguration configuration;

    public TypizedMiddleware(IConfiguration configuration)
    {
        this.configuration = configuration;
    }
    
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        System.Console.WriteLine(nameof(TypizedMiddleware));
        System.Console.WriteLine(this.configuration.GetHashCode());

        if(Random.Shared.Next(2) == 1) {
            await next.Invoke(context);
        }
        else {
            context.Response.StatusCode = 500;
        }
    }
}
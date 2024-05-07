namespace MiddlewareApp.Middlewares;

public class FirstMiddleware
{
    private readonly RequestDelegate next;
    public FirstMiddleware(RequestDelegate next)
    {
        this.next = next;
    }

    public async Task InvokeAsync(HttpContext httpContext) {
        System.Console.WriteLine("START FirstMiddleware");
        await this.next.Invoke(httpContext);
        System.Console.WriteLine("END FirstMiddleware");
    }
}
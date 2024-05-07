namespace MiddlewareApp.Middlewares
{
    public class SecondMiddleware
    {
        private readonly RequestDelegate next;
        public SecondMiddleware(RequestDelegate next)
        {
            this.next = next;
        }
        public async Task InvokeAsync(HttpContext httpContext) {
            System.Console.WriteLine("START SecondMiddleware");
            await this.next.Invoke(httpContext);
            System.Console.WriteLine("END SecondMiddleware");
        }
    }
}
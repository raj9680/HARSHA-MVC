namespace Middleware3
{
    public class MyCustomMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("Custom Middleware - Starts");
            await next(context);
            await context.Response.WriteAsync("Custom Middleware - Ends");
        }
    }


    // Custom Extension Middleware Method
    public static class CustomMiddlewareExtension
    {
        public static IApplicationBuilder UseMyCustomMiddleware(this IApplicationBuilder app)
        {
            // any code
            return app.UseMiddleware<MyCustomMiddleware>();
        }
    }
}

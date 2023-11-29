using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Middleware5.LoginMiddlewareApplication
{
    public class LoginConventionalMiddleware
    {
        private readonly RequestDelegate _next;

        public LoginConventionalMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {

            return _next(httpContext);
        }
    }

    
    
    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class LoginConventionalMiddlewareExtensions
    {
        public static IApplicationBuilder UseLoginConventionalMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LoginConventionalMiddleware>();
        }
    }
}

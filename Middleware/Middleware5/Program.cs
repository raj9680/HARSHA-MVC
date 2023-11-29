var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// if
app.UseWhen(
    context => context.Request.Query.ContainsKey("username"),
    async app =>
    {
        app.Use(async (context, next) =>
        {
            await context.Response.WriteAsync("Hello from middleware branch \n");
            await next();
        });
    });

// else
app.Run(async context =>
{
    await context.Response.WriteAsync("Hello from middleware at main chain");
});

// login middleware

app.Run();


// Order of middleware should be 
/*
 * 1. ExceptionHandler
 * 2. HSTS
 * 3. HttpsRedirection
 * 4. Static Files
 * 5. Routing
 * 6. CORS
 * 7. Authentication
 * 8. Authorization
 * 9. Custom Middleware 1
 * 10. Custom Middleware 2
 * 11. -Endpoints(controllers)
*/


// Code of Order of middlewares
/*
 * app.UseExceptionHandler("/Error");
 * app.UseHsts();
 * app.UseHttpsRedirection();
 * app.UseStaticFiles();
 * app.UseRouting();
 * app.UseCors();
 * app.UseAuthentication();
 * app.UseAuthorization();
 * app.UseSession();
 * app.MapControllers();
 * add your custom middlewares
 * app.Run();
*/

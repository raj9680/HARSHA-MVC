var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//Middleware1 // app.Use() shortcircuit execute or pass the control to nextt middleware
app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("Hello");
});

//Middleware 2
app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("Hello");
});

app.Run();

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// enable Routing
app.UseRouting();

// Get Endpoint Info
app.Use(async (context, next) =>
{
    Microsoft.AspNetCore.Http.Endpoint? endPoint = context.GetEndpoint();
    if (endPoint != null)
        await context.Response.WriteAsync($"endpoint: {endPoint.DisplayName}");
    await next(context);
});

// created endpoints
app.UseEndpoints(endpoints =>
{
    // add your endpoints here
    endpoints.Map("map1", async (context) =>  // execute for any request
    {
        await context.Response.WriteAsync("In Map One");
    });

    endpoints.MapPost("map2", async (context) => // execute for POST request only
    {
        await context.Response.WriteAsync("In Map Two");
    });
});

// for all other endpoints
app.Run(async context =>
{
    await context.Response.WriteAsync($"Request received at {context.Request.Path}");
});

app.Run();

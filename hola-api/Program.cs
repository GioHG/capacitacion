var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => Results.Ok(new
{
    message = "Hola desde .NET 8 en OpenShift",
    app = "hola-api",
    branch = "hector",
    utc = DateTime.UtcNow
}));

app.MapGet("/health", () => Results.Ok(new
{
    status = "ok",
    utc = DateTime.UtcNow
}));

app.Run();
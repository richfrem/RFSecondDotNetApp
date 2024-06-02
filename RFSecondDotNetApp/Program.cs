var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "My Second.NET project from VS Code");

app.Run();

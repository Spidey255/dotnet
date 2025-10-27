var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "hi there!");

app.Run();

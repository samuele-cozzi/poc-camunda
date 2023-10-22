var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHealthChecks();

var app = builder.Build();

app.MapHealthChecks("/");

app.MapGet("/hello", () => "Hello World!");

app.Run();

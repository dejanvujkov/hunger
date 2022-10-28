using Hunger.Startup;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.RegisterServices();

var app = builder.Build();

// Configure Environment
app.Configure();

app.Run();
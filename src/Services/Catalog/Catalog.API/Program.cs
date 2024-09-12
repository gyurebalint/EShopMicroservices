var builder = WebApplication.CreateBuilder(args);

// Add services to container

var app = builder.Build();

// Configure the http request pipeline

app.Run();

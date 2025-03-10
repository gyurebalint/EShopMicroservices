var builder = WebApplication.CreateBuilder(args);

// add services to DI

var app = builder.Build();

// Configure the http request pipeline

app.Run();

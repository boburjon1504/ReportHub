using ReportHub.Api.Configurations;

var builder = WebApplication.CreateBuilder(args);

await builder.ConfigureAsync();

var app = builder.Build();

await app.ConfigureAsync();

app.Run();

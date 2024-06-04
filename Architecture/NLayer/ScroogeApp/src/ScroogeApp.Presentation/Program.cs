using ScroogeApp.Core.Services;
using ScroogeApp.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddControllers();

builder.Services.AddSingleton<ITalkingService, TalkingConsoleService>();

var app = builder.Build();

app.MapControllers();

app.Run();
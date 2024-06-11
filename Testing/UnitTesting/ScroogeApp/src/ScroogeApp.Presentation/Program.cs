using System.Reflection;
using Microsoft.EntityFrameworkCore;
using ScroogeApp.Core.Repositories;
using ScroogeApp.Core.Services;
using ScroogeApp.Infrastructure.Data;
using ScroogeApp.Infrastructure.Repositories;
using ScroogeApp.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddControllers();

builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<ITalkingService, TalkingConsoleService>();
builder.Services.AddScoped<IUserRepository, UserEfRepository>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddDbContext<MyDbContext>(dbContextOptionsBuilder => {
    var connectionString = builder.Configuration.GetConnectionString("MsSqlServer");
    dbContextOptionsBuilder.UseSqlServer(connectionString, options => {
        options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
    });
});

var app = builder.Build();

app.MapControllers();

app.UseSwagger();
app.UseSwaggerUI();

app.Run();
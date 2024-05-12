// Storage:
// SQL Tokens table ["724zz323afa34", "243612f124", ...]

// TokenMiddleware: 
// проверяет, есть ли токен в запросе и валидный ли он
// токен есть: пропускаем
// токена нет: status code = 401

// token:
// queryParameter: domain.com/controller/action?token={TOKEN}

using TokenValidatorMiddlewareApp.Middlewares;
using TokenValidatorMiddlewareApp.Repositories;
using TokenValidatorMiddlewareApp.Repositories.Base;
using TokenValidatorMiddlewareApp.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddTransient<ITokenRepository, TokenSqlDapperRepository>();
builder.Services.AddScoped<TokenService>();

var app = builder.Build();

app.MapControllers();
app.UseMiddleware<TokenValidationMiddleware>();

app.Run();
using MiddlewareApp.Middlewares;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddTransient<TypizedMiddleware>();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();

app.UseMiddleware<FirstMiddleware>();
app.UseMiddleware<SecondMiddleware>();
app.UseMiddleware<SaySomethingMiddleware>();
app.UseMiddleware<TypizedMiddleware>();

app.MapDefaultControllerRoute();
app.Run();





// Storage:
// SQL Tokens table ["724zz323afa34", "243612f124", ...]

// TokenMiddleware: 
// проверяет, есть ли токен в запросе и валидный ли он
// токен есть: пропускаем
// токена нет: status code = 401

// token:
// queryParameter: domain.com/controller/action?token={TOKEN}
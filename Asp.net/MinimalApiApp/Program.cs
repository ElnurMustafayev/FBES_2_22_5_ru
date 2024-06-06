using System.Linq.Expressions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.MapGet("/api/Test/{name}", (string name) =>
{
    return new {
        Value = 777,
    };
});

app.MapMethods("/test", new string[] {"GET", "POST"}, () => {
    return "OK";
});

app.Run();
using WebApi2.BackgroudServices;
using WebApi2.Options;

var builder = WebApplication.CreateBuilder(args);

var rabbitMqSection = builder.Configuration.GetSection("RabbitMq");
builder.Services.Configure<RabbitMqOptions>(rabbitMqSection);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

builder.Services.AddHostedService<PullNewUsersRabbitMqService>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();

app.Run();
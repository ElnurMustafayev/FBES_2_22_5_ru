using WebApi1.Options;
using WebApi1.Services;
using WebApi1.Services.Base;

var builder = WebApplication.CreateBuilder(args);

var rabbitMqSection = builder.Configuration.GetSection("RabbitMq");
builder.Services.Configure<RabbitMqOptions>(rabbitMqSection);

builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IMessageBrokerService, RabbitMqService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();

app.Run();
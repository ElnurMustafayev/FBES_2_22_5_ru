using System.Reflection;
using Cqrs.Repositories;
using Cqrs.Repositories.Base;
using Cqrs.Wallets.Entities;
using Cqrs.Wallets.Repositories;
using Cqrs.Wallets.Repositories.Base;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMediatR(configuration => {
    configuration.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
});

builder.Services.AddTransient<IWalletRepository<Wallet>, WalletDapperRepository>();
builder.Services.AddTransient<IDatabaseRepository, DatabaseDapperRepository>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();

var serviceScope = app.Services.CreateScope();
var databaseRepository = serviceScope.ServiceProvider.GetRequiredService<IDatabaseRepository>();
await databaseRepository.InitDbAsync();

app.Run();
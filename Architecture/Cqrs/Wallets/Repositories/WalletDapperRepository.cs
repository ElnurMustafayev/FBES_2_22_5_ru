namespace Cqrs.Wallets.Repositories;

using Cqrs.Wallets.Entities;
using Cqrs.Wallets.Repositories.Base;
using Dapper;
using Microsoft.Data.SqlClient;

public class WalletDapperRepository : IWalletRepository<Wallet>
{
    private readonly IConfiguration configuration;
    public WalletDapperRepository(IConfiguration configuration)
    {
        this.configuration = configuration;
    }
    
    public async Task CreateAsync(Wallet newWallet)
    {
        var connectionString = this.configuration.GetConnectionString("CqrsDb");

        using var connection = new SqlConnection(connectionString);
        await connection.ExecuteAsync(
            @"insert into Wallets (Balance, Currency, Rate)
            values (@Balance, @Currency, @Rate)", 
            param: newWallet);
    }
}
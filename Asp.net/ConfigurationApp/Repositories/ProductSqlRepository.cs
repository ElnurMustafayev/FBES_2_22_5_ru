namespace ConfigurationApp.Repositories;

using System.Data.SqlClient;
using ConfigurationApp.Extensions;
using ConfigurationApp.Options.Connections;
using ConfigurationApp.Repositories.Base;
using Dapper;
using Microsoft.Extensions.Options;

public class ProductSqlRepository : IProductRepository
{
    private readonly string connectionString;
    //private readonly MsSqlConnectionOptions msSqlConnectionOptions;


    public ProductSqlRepository(IOptionsSnapshot<MsSqlConnectionOptions> msSqlConnectionOptions)
    {
        //this.msSqlConnectionOptions = msSqlConnectionOptions.Value;
        this.connectionString = msSqlConnectionOptions.Value.ConnectionString;
        // this.connectionString = configuration.GetConnectionStringOrThrowArgumentException("SqlDb");
    }

    public async Task<long> GetMaxIdAsync()
    {
        using var connection = new SqlConnection(this.connectionString);

        return await connection.ExecuteScalarAsync<long>("select max(Id) from Products");
    }
}
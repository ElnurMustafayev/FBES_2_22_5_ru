namespace ConfigurationApp.Repositories;

using System.Data.SqlClient;
using ConfigurationApp.Extensions;
using ConfigurationApp.Repositories.Base;
using Dapper;

public class ProductSqlRepository : IProductRepository
{
    private readonly string connectionString;

    public ProductSqlRepository(IConfiguration configuration)
    {
        this.connectionString = configuration.GetConnectionStringOrThrowArgumentException("SqlDb");
    }

    public async Task<long> GetMaxIdAsync()
    {
        using var connection = new SqlConnection(connectionString);

        return await connection.ExecuteScalarAsync<long>("select max(Id) from Products");
    }
}
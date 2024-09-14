using Dapper;
using Npgsql;
using ProductsWebApi.Entities;
using ProductsWebApi.Repositories.Base;

namespace ProductsWebApi.Repositories;

public class ProductPostgreSqlRepository : IProductRepository
{
    private readonly string connectionString;
    public ProductPostgreSqlRepository(IConfiguration configuration)
    {
        this.connectionString = configuration.GetConnectionString("PostgreSql") ?? throw new ArgumentException();
    }

    public async Task<Product?> GetAsync(int id)
    {
        using var connection = new NpgsqlConnection(this.connectionString);

        var product = await connection.QueryFirstOrDefaultAsync<Product>(
            "select * from Products where Id = @Id",
            new {
                Id = id
            }
        );

        return product;
    }
}
namespace DependencyInjectionApp.Repositories;

using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using DependencyInjectionApp.Models;
using DependencyInjectionApp.Repositories.Base;
using Dapper;

public class ProductSqlRepository : IProductRepository
{
    private const string ConnectionString = "Database=DependencyInjectionDb;Server=localhost;User Id=sa;Password=Admin9264!!;TrustServerCertificate=True;";

    public async Task CreateAsync(Product newProduct)
    {
        using var connection = new SqlConnection(ConnectionString);

        await connection.ExecuteAsync(
            @"insert into Products(Name, Price, InStock, Discount) 
            values (@Name, @Price, @InStock, @Discount)", newProduct);
    }

    public async Task<IEnumerable<Product>?> GetAllAsync()
    {
        using var connection = new SqlConnection(ConnectionString);

        return await connection.QueryAsync<Product>(@"select * from Products");
    }
}
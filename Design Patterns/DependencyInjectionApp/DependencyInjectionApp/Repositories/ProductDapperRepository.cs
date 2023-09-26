using Dapper;
using DependencyInjectionApp.Models;
using DependencyInjectionApp.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionApp.Repositories
{
    public class ProductDapperRepository : IProductRepository
    {
        private const string connectionString = $"Server=localhost;Database=StorageDb;User Id=admin;Password=admin;";
        private readonly SqlConnection sqlConnection;

        public ProductDapperRepository()
        {
            this.sqlConnection = new SqlConnection(connectionString);
            this.sqlConnection.Open();
        }

        public IEnumerable<Product> GetAll()
        {
            //return this.sqlConnection.Query<Product>(sql: "SELECT CAST([Id] AS nvarchar(36)) as 'Id',[Name],[Price],[Status] FROM Products");
            return this.sqlConnection.Query<Product>(sql: "select * from Products");
        }

        public void Create(Product product)
        {
            string query = $@"insert into Products([Name], [Price], [Status])
                            values(@Name, @Price, @Status)";

            int affectedRowsCount = this.sqlConnection.Execute(query, param: product);

            if (affectedRowsCount <= 0)
                throw new Exception("Insert error!");
        }
    }
}

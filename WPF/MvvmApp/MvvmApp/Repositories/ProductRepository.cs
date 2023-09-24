using Dapper;
using MvvmApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmApp.Repositories
{
    public class ProductRepository
    {
        private const string connectionString = $"Server=localhost;Database=StorageDb;User Id=admin;Password=admin;";
        private readonly SqlConnection sqlConnection;

        public ProductRepository()
        {
            this.sqlConnection = new SqlConnection(connectionString);
            this.sqlConnection.Open();
        }

        public IEnumerable<Product> GetAll()
        {
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

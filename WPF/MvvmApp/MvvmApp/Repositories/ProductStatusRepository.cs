using MvvmApp.Models;
using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MvvmApp.Repositories
{
    public class ProductStatusRepository
    {
        private const string connectionString = $"Server=localhost;Database=StorageDb;User Id=admin;Password=admin;";
        private readonly SqlConnection sqlConnection;

        public ProductStatusRepository()
        {
            this.sqlConnection = new SqlConnection(connectionString);
            this.sqlConnection.Open();
        }

        public IEnumerable<ProductStatus> GetAll()
        {
            return this.sqlConnection.Query<ProductStatus>(sql: "select * from ProductStatuses");
        }
    }
}

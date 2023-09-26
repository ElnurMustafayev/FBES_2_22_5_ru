using MvvmApp.Models;
using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;
using MvvmApp.Repositories.Base;

namespace MvvmApp.Repositories
{
    public class ProductStatusDapperRepository : IProductStatusRepository
    {
        private const string connectionString = $"Server=localhost;Database=StorageDb;User Id=admin;Password=admin;";
        private readonly SqlConnection sqlConnection;

        public ProductStatusDapperRepository()
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

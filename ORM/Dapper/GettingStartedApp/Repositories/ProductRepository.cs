using Dapper;
using GettingStartedApp.Entities;
using GettingStartedApp.QueryParameters;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStartedApp.Repositories
{
    public class ProductRepository
    {
        private readonly SqlConnection sqlConnection;

        public ProductRepository(string connectinoString)
        {
            this.sqlConnection = new SqlConnection(connectinoString);
            this.sqlConnection.Open();
        }

        public Product GetById(int id)
        {
            return this.sqlConnection.QueryFirst<Product>(
                sql: "select * from Products p where p.Id = @Id", 
                param: new ProductQueryParameters { Id = id });
        }

        public Product GetByName(string name)
        {
            return this.sqlConnection.QueryFirst<Product>(
                sql: "select * from Products p where p.Name = @Name", 
                param: new { Name = name });
        }
    }
}

using Dapper;
using Microsoft.AspNetCore.Mvc;
using Npgsql;

namespace WebApiApp.Controllers
{
    [Route("/api/[controller]/[action]")]
    public class TestController : ControllerBase
    {
        private string postgreSqlConnectionString;

        public TestController(IConfiguration configuration)
        {
            this.postgreSqlConnectionString = configuration.GetConnectionString("PostgreSql")!;
        }
        
        [HttpGet]
        public async Task<long> Count() {
            using var connection = new NpgsqlConnection(this.postgreSqlConnectionString);

            var result = await connection.ExecuteScalarAsync<long>("select count(*) from Products");

            return result;
        }
    }
}
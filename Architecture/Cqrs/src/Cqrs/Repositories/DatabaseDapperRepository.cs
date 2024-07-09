using Cqrs.Repositories.Base;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Cqrs.Repositories
{
    public class DatabaseDapperRepository : IDatabaseRepository
    {
        private readonly IConfiguration configuration;
        public DatabaseDapperRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public async Task InitDbAsync()
        {
            var masterConnectionString = this.configuration.GetConnectionString("MasterDb");
            ArgumentNullException.ThrowIfNullOrWhiteSpace(masterConnectionString, nameof(masterConnectionString));
            using (var connectionToMaster = new SqlConnection(masterConnectionString))
            {
                var sqlScript = await File.ReadAllTextAsync("Sql/init_db.sql");
                await connectionToMaster.ExecuteAsync(sqlScript);
            }

            var connectionString = this.configuration.GetConnectionString("CqrsDb");
            ArgumentNullException.ThrowIfNullOrWhiteSpace(connectionString, nameof(connectionString));
            using (var connection = new SqlConnection(connectionString))
            {
                var sqlScript = await File.ReadAllTextAsync("Sql/init_tables.sql");
                await connection.ExecuteAsync(sqlScript);
            }
        }
    }
}
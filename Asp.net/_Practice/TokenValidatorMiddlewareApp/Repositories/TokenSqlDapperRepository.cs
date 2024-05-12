namespace TokenValidatorMiddlewareApp.Repositories;

using Dapper;
using Microsoft.Data.SqlClient;
using TokenValidatorMiddlewareApp.Models;
using TokenValidatorMiddlewareApp.Repositories.Base;

public class TokenSqlDapperRepository : ITokenRepository
{
    private readonly string connectionString; 
    public TokenSqlDapperRepository(IConfiguration configuration)
    {
        var sqlConnectionString = configuration.GetConnectionString("SqlConnectionString");
        ArgumentNullException.ThrowIfNullOrEmpty(sqlConnectionString);
        this.connectionString = sqlConnectionString;
    }

    public async Task<Token?> GetTokenAsync(string tokenId)
    {
        using var connection = new SqlConnection(this.connectionString);

        var token = await connection.QueryFirstOrDefaultAsync<Token>(
            "select * from Tokens where TokenId = @TokenId",
            new {
                TokenId = tokenId
            }
        );
        
        return token;
    }

    public async Task<IEnumerable<Token>> GetTokensAsync()
    {
        using var connection = new SqlConnection(this.connectionString);

        var tokens = await connection.QueryAsync<Token>("select * from Tokens");
        
        return tokens;
    }
}


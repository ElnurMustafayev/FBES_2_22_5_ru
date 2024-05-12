using TokenValidatorMiddlewareApp.Models;

namespace TokenValidatorMiddlewareApp.Repositories.Base;

public interface ITokenRepository
{
    Task<IEnumerable<Token>> GetTokensAsync();
    Task<Token?> GetTokenAsync(string tokenId);
}
#pragma warning disable IDE0270

using TokenValidatorMiddlewareApp.Exceptions;
using TokenValidatorMiddlewareApp.Models;
using TokenValidatorMiddlewareApp.Repositories.Base;

namespace TokenValidatorMiddlewareApp.Services;

public class TokenService
{
    private readonly ITokenRepository tokenRepository;
    public TokenService(ITokenRepository tokenRepository)
    {
        this.tokenRepository = tokenRepository;
    }

    public async Task<Token> GetTokenAsync(string token) {
        var foundToken = await this.tokenRepository.GetTokenAsync(token);

        if (foundToken == null) {
            throw new NotFoundException(nameof(Token));
        }

        return foundToken;
    }

    public async Task<bool> IsTokenExistAsync(string token) {
        var foundToken = await this.tokenRepository.GetTokenAsync(token);

        return foundToken != null;
    }

    public async Task<IEnumerable<Token>> GetAllTokensAsync() {
        var tokens = await this.tokenRepository.GetTokensAsync();

        return tokens;
    }
}
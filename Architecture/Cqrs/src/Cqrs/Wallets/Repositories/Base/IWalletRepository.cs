namespace Cqrs.Wallets.Repositories.Base;

public interface IWalletRepository<TWallet>
{
    Task CreateAsync(TWallet newWallet);
}
namespace Cqrs.Wallets.Handlers;

using Cqrs.Wallets.Commands;
using Cqrs.Wallets.Entities;
using Cqrs.Wallets.Repositories.Base;
using MediatR;

public class CreateHandler : IRequestHandler<CreateWalletCommand, bool>
{
    private readonly IWalletRepository<Wallet> walletRepository;

    public CreateHandler(IWalletRepository<Wallet> walletRepository)
    {
        this.walletRepository = walletRepository;
    }

    public async Task<bool> Handle(CreateWalletCommand request, CancellationToken cancellationToken)
    {
        if(request.Currency.Length >= 10) {
            throw new ArgumentException("Currency is >= 10!");
        }
        else if(request.Balance < 0) {
            throw new ArgumentException("Balance is < 10!");
        }
        else if(request.Rate <= 0) {
            throw new ArgumentException("Rate is <= 0!");
        }

        var newWallet = new Wallet {
            Id = 0,
            Currency = request.Currency,
            Balance = request.Balance,
            Rate = request.Rate,
        };

        await this.walletRepository.CreateAsync(newWallet);

        return true;
    }
}
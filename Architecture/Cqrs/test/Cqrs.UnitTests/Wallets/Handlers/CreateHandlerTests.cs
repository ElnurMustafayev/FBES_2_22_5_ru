using Cqrs.Wallets.Commands;
using Cqrs.Wallets.Entities;
using Cqrs.Wallets.Handlers;
using Cqrs.Wallets.Repositories;
using Cqrs.Wallets.Repositories.Base;
using Moq;

namespace Cqrs.UnitTests.Wallets.Handlers;

public class CreateHandlerTests
{
    private readonly CreateWalletCommand correctCommand;
    private const string correctCurrency = "azn";
    private const double correctBalance = 100;
    private const double correctRate = 1.7;

    public CreateHandlerTests()
    {
        this.correctCommand = new CreateWalletCommand() {
            Currency = correctCurrency,
            Balance = correctBalance,
            Rate = correctRate,
        };
    }

    [Theory]
    [InlineData("verylongcurrency", correctBalance, correctRate)]
    // [InlineData(null, correctBalance, correctRate)]
    [InlineData(correctCurrency, -1, correctRate)]
    [InlineData(correctCurrency, correctBalance, 0)]
    [InlineData(correctCurrency, correctBalance, -10)]
    public async Task Handle_SendIncorrectData_ThrowsArgumentException(string currency, double balance, double rate) {
        var command = new CreateWalletCommand() {
            Currency = currency,
            Balance = balance,
            Rate = rate,
        };

        var handler = new CreateHandler(null);

        await Assert.ThrowsAsync<ArgumentException>(async () => await handler.Handle(command, CancellationToken.None));
    }

    [Fact]
    public async Task Handle_SendCorrectData_Works() {
        var newWallet = new Wallet {
            Id = 0,
            Currency = this.correctCommand.Currency,
            Balance = this.correctCommand.Balance,
            Rate = this.correctCommand.Rate,
        };

        var walletRepositoryMock = new Mock<IWalletRepository<Wallet>>();
        walletRepositoryMock.Setup(repo => repo.CreateAsync(newWallet));
        var handler = new CreateHandler(walletRepositoryMock.Object);
        
        Assert.True(await handler.Handle(this.correctCommand, CancellationToken.None));
    }
}
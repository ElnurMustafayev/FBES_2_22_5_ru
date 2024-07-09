using MediatR;

namespace Cqrs.Wallets.Commands;

public class CreateWalletCommand : IRequest<bool>
{
    public double Balance { get; set; }
    public required string Currency { get; set; }
    public double Rate { get; set; }
}
#pragma warning disable CS8618

namespace Cqrs.Wallets.Entities;

public class Wallet
{
    public int Id { get; set; }
    public double Balance { get; set; }
    public string Currency { get; set; }
    public double Rate { get; set; }
}
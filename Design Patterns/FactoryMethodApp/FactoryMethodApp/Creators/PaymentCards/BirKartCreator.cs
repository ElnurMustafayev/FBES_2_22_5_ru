namespace FactoryMethodApp.Creators.PaymentCards;

using FactoryMethodApp.Creators.Base;
using FactoryMethodApp.Models;
using FactoryMethodApp.Models.Base;

public class BirKartCreator : ICardCreator {
    private string GenerateCardNumber() => $"{Random.Shared.Next(1000, 9999)} {Random.Shared.Next(1000, 9999)} {Random.Shared.Next(1000, 9999)} {Random.Shared.Next(1000, 9999)}";

    public Card Create() {
        return new PaymentCard() {
            Name = "BirKart",
            Amount = 0,
            ExpDate = DateTime.Now.AddYears(5),
            CVV = new Random().Next(100, 999),
            CardNumber = this.GenerateCardNumber(),
        };
    }
}
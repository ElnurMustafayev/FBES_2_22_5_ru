namespace FactoryMethodApp.Creators.TransportCards;

using FactoryMethodApp.Creators.Base;
using FactoryMethodApp.Enums;
using FactoryMethodApp.Models;
using FactoryMethodApp.Models.Base;

public class BakiKartCreator : ICardCreator {
    public Card Create() {
        return new TransportCard() {
            Name = "Bakikart",
            Amount = 0,
            FreeTrips = false,
            TransportTypes = new TransportType[] {
                TransportType.subway,
                TransportType.bus
            },
        };
    }
}
namespace FactoryMethodApp.Creators.TransportCards;

using FactoryMethodApp.Creators.Base;
using FactoryMethodApp.Enums;
using FactoryMethodApp.Models.Base;
using FactoryMethodApp.Models;

public class AeroportCardCreator : ICardCreator {
    public Card Create() {
        return new TransportCard() {
            Name = "Aeroport card",
            Amount = null,
            FreeTrips = false,
            TransportTypes = new TransportType[] {
                TransportType.plane
            },
        };
    }
}
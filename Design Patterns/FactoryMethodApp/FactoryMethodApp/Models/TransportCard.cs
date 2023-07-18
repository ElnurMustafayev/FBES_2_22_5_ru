namespace FactoryMethodApp.Models;

using FactoryMethodApp.Enums;
using FactoryMethodApp.Models.Base;

public class TransportCard : Card {
    public IEnumerable<TransportType>? TransportTypes { get; set; }
    public bool FreeTrips { get; set; } = false;











    //public static TransportCard CreateBakiKart() {
    //    return new TransportCard() {
    //        Name = "Bakikart",
    //        Amount = 0,
    //        FreeTrips = false,
    //        TransportTypes = new TransportType[] {
    //            TransportType.subway,
    //            TransportType.bus
    //        },
    //    };
    //}

    //public static TransportCard CreateAeroportCard() {
    //    return new TransportCard() {
    //        Name = "Aeroport card",
    //        Amount = null,
    //        FreeTrips = false,
    //        TransportTypes = new TransportType[] {
    //            TransportType.plane
    //        },
    //    };
    //}
}
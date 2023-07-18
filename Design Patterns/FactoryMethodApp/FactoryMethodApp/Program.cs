using FactoryMethodApp.Creators.Base;
using FactoryMethodApp.Creators.PaymentCards;
using FactoryMethodApp.Creators.TransportCards;
using FactoryMethodApp.Enums;
using FactoryMethodApp.Models;
using FactoryMethodApp.Models.Base;

namespace FactoryMethodApp;

public class Program {
    static Card CreateCardWithSpecificName(ICardCreator cardCreator, string? name = null) {
        var card = cardCreator.Create();

        if(string.IsNullOrWhiteSpace(name) == false)
            card.Name = name;

        return card;
    }

    static void Main() {
        var card = CreateCardWithSpecificName(new BirKartCreator());
        Console.WriteLine(card);



        //ICardCreator cardCreator = new BakiKartCreator();
        //var card = cardCreator.Create();



        //TransportCard.CreateBakiKart();
        //TransportCard.CreateAeroportCard();
    }
}
namespace FactoryMethodApp.Models;

using FactoryMethodApp.Models.Base;

public class PaymentCard : Card {
    public string? CardNumber { get; set; }
    public int? CVV { get; set; }
    public DateTime? ExpDate { get; set; }
}
namespace FactoryMethodApp.Models.Base;

public class Card {
    public string Name { get; set; }
    public double? Amount { get; set; }

    public override string ToString() {
        return @$"Card type: {this.GetType().Name}
Name: {Name}
Amount: {(Amount?.ToString() ?? "Unknown")}$";
    }
}
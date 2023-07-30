namespace CompositeApp.Items;

using CompositeApp.Items.Base;

public class Product : Item {
    private readonly decimal price;
    public override decimal Price => this.price;

    public Product(string name, decimal price) : base(name) {
        this.price = price < 0 ? 0 : price;
    }

    public override string ToString() => $"{base.ToString()} {this.Price}$";
}
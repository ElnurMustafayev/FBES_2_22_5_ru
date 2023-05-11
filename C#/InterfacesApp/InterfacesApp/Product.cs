namespace InterfacesApp;

public class ProductBase {
    public string Name { get; set; }
    public double Price { get; set; }

    public ProductBase(string name, double price) {
        this.Name = name;
        this.Price = price;
    }
}

public class Product : ProductBase, IShowable {
    public Product(string name, double price) : base(name, price) { }

    public void ShowInConsole() {
        Console.WriteLine($@"Name: {base.Name}
Price: {base.Price}$");
    }
}
namespace MoneyConverterApp;

public class Currency {
    public string Name { get; set; }
    public double Rate { get; set; }

    public Currency(string name, double rate) {
        this.Name = name;
        this.Rate = rate;
    }

    public double Convert(double money) => money * this.Rate;

    public override string ToString() => this.Name;
}

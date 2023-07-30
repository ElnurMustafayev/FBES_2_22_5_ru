namespace CompositeApp.Containers;

public class Box : Component {
	private static uint SerialNumberCounter = 0;
    public readonly string SerailNumber;

    public List<Component> Items { get; set; }

    public override decimal Price => Items?.Sum(item => item.Price) ?? 0;

    //public override decimal Price {
    //    get {
    //        decimal sum = 0;
    //        foreach (var item in Items) {
    //            sum += item.Price;
    //        }

    //        return sum;
    //    }
    //}

    public Box() {
        this.SerailNumber = (++Box.SerialNumberCounter).ToString();
        this.Items = new List<Component>();
    }

    public override string ToString() {
        var toStrings = this.Items.Select(item => item.ToString());
        return string.Join('\n', toStrings);
    }
}
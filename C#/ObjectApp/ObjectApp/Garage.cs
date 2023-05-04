namespace ObjectApp;

public class Garage {
    public string Name { get; set; }
    public string Address { get; set; }
    public List<Car> Cars { get; set; }

    public Garage() {
        Cars = new List<Car>();
    }
}
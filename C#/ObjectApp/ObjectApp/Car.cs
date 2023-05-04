namespace ObjectApp;

public class Car {
    public string Model { get; set; }
    public string Brand { get; set; }

    public override string ToString() {
        return $"{Brand}: {Model}";
    }

    public override int GetHashCode() {
        return base.GetHashCode();
    }

    public override bool Equals(object? obj) {
        //return base.Equals(obj);

        if(obj is Car) {
            var otherCar = obj as Car;

            return this.Model == otherCar.Model 
                && this.Brand == otherCar.Brand;
        }

        return base.Equals(obj);
    }
}
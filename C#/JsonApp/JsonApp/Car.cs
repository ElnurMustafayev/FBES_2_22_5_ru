namespace JsonApp {
    public class Car {
        public double[] Test { get; set; } = new double[] { 12.5, 13.5, 14.5 };
        public string Model { get; set; }
        public double MaxSpeed { get; set; }
        public User Driver { get; set; }

        public List<User> Passengers { get; set; }

        public Car(string model, double maxSpeed) {
            Model = model;
            MaxSpeed = maxSpeed;
        }

        //public Car() {

        //}
    }
}

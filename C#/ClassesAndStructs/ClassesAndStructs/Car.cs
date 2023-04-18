namespace ClassesAndStructs {
    struct Car {
        public string Model;
        public int MaxSpeed;
        public Person Driver;

        public Car(int maxSpeed, Person driver) : this() {
            this.MaxSpeed = maxSpeed;
            this.Driver = driver;
        }

        public Car() {
            this.Model = "Unknown";
            this.MaxSpeed = 280;
            this.Driver = new Person();
        }

        public string GetInfo() {
            return $"{this.Model}: {this.MaxSpeed} km/h";
        }

        public void Show() {
            Console.WriteLine("Car:");
            Console.WriteLine(this.GetInfo());
            Console.WriteLine("Driver:");
            Driver.Show();
        }
    }
}

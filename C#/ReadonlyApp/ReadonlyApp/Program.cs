namespace ReadonlyApp {

    class MyClass {
        public int Number { get; }
        public readonly string Text = "qwerty";

        public MyClass(int number) {
            this.Number = number;
            this.Text = "one";
            this.Text = "two";
            this.Text = "three";
        }

        public void test() {
            Console.WriteLine(this.Text);
        }
    }

    class Car {
        // public string Model { get; }
        public readonly string Model;

        public Car(string model) {
            this.Model = model;
        }
    }

    internal class Program {
        static void Main() {
            Car car = new Car(model: "Uazik");

            // car.Model = "Bmw"; // rean-only field

            Console.WriteLine(car.Model);




            //var obj = new MyClass(123);

            //Console.WriteLine(obj.Number);
        }
    }
}
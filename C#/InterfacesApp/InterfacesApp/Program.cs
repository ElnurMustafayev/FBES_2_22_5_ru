namespace InterfacesApp {
    public class Aircraft {
        public void Fly() {

        }
    }

    public class Transport {
        public double Speed { get; set; }
    }

    //public interface IBird { }
    //public interface IFly { }
    public interface IFlyable {
        void Fly();
        int Test();
    }

    public class FlyableCar : IFlyable {
        public void Fly() {

        }

        public int Test() {
            throw new NotImplementedException();
        }
    }

    class Program {
        static void Main() {
            //IFlyable test;
            //new IFlyable();

            Product product = new Product(name: "Apples", price: 3);

            product.ShowInConsole();
        }
    }
}
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
}
namespace InterfacesApp {
    public interface IHardInterface {
        void Method1();
        void Method2() { }
        void Method3();
    }

    public interface IInterface {
        void MethodFromInterface();
    }

    public interface IInterfaceWithProp {
        int Num { get; set; }
    }

    public interface ISuperInterface : IInterface, IInterfaceWithProp {
        int Test();
    }

    public class A : IInterface {
        public void MethodFromInterface() {
            Console.WriteLine("Implementation A");
        }
    }

    public class B : IInterface, IInterfaceWithProp {
        public int Num { get => 0; set => Console.WriteLine(); }
        public void MethodFromInterface() {
            Console.WriteLine("Implementation B");
        }
    }

    public struct C : IInterfaceWithProp {
        public int Num { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    public class D : ISuperInterface {
        public int Num { get => 0; set => Console.WriteLine(); }
        public void MethodFromInterface() => Console.WriteLine();
        public int Test() => 0;
    }


    class Program {

        //static IInterface GetObject(ISuperInterface obj) {
        //    return obj;
        //}

        static void Main() {
            //IInterface obj = new B();
            //obj.MethodFromInterface();

            //obj = new A();
            //obj.MethodFromInterface();






            //foreach (char symbol in "Hello World!") {
            //    Console.WriteLine(symbol);
            //}


            //int[] arr = {
            //    1,2,3,4,5
            //};

            //string[] names = {
            //    "Emil",
            //    "Aydin",
            //    "Elnur"
            //};
            //foreach (var name in names) {
            //    Console.WriteLine("- - - - - -");
            //    foreach (var symbol in name) {
            //        Console.Write($"{symbol} ");
            //    }
            //    Console.WriteLine();
            //}



            //List<int> collection = new List<int>() {
            //    1,4,76,23,45,2,6
            //};

            //collection.Reverse();
            ////collection.Sort();

            //foreach (var item in collection) {
            //    Console.WriteLine(item);
            //}



            //var random = new Random();

            //foreach (var element in random) {

            //}


            var shop = new Shop();
            shop.Goods.Add(new Goods("Bananas"));
            shop.Goods.Add(new Goods("Apples"));
            shop.Goods.Add(new Goods("Phone"));

            foreach (var item in shop) {
                Console.WriteLine(item);
            }


            int[] arr = { 1, 2, 3 };
            PrintCollection(arr);
            PrintCollection(new List<int>());
            PrintCollection(new HashSet<int>());
            PrintCollection(new Queue<int>());
        }

        public static void PrintCollection(IEnumerable<int> collection) {
            int index = 1;
            foreach (var item in collection) {
                Console.WriteLine($"{index++}. {item}");
            }
        }
    }
}
namespace PolymorphysmApp {
    public class A {
        protected int number;
        public virtual int Number { 
            get => number;
            set {
                number = value + 1;
            }
        }

        public virtual void Func() {
            Console.WriteLine("A");
        }
    }

    public class B : A {
        public override int Number {
            get => Math.Abs(base.Number);
            set {
                number = value + 2;
            }
        }

        //public override void Func() {
        //    base.Func();
        //    Console.WriteLine("B");
        //    this.Func();
        //}
    }

    public class Program {
        static void PrintNumber(A obj) {
            obj.Number = 100;
            Console.WriteLine(obj.Number);
        }

        static void CallFunc(A obj) {
            obj.Func();
        }

        public static void ShowProductInfo(Product product) {
            product.ShowInfo();
        }

        static void Main() {
            Product product1 = new Product() {
                Name = "Table",
                Price = 150,
            };

            FreshProduct product2 = new FreshProduct() {
                Name = "Banana",
                Price = 1,
                ExpirationDateStr = "10.05.2023",
            };

            Product.ShowProductInfo(product1);
            Program.ShowProductInfo(product2);

            //CallFunc(new A());   // A
            //Console.WriteLine();
            //CallFunc(new B());   // ABA



            //B b = new B();
            //b.Number = 777;
            //Console.WriteLine(b.Number);


            //A a = new A();
            //a.Number = 777;
            //Console.WriteLine(a.Number);



            //A a = new A();
            //a.Func();
            //B b = new B();
            //b.Func();

            //A a = new A();
            //a.Func();       // A
            //a = new B();
            //a.Func();       // B
        }
    }
}
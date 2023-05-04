namespace ObjectApp {
    class Program {
        static void Main() {
            Garage garage = new Garage();
            garage.Cars.Add(new Car() { Brand = "BMW", Model = "M5" });


            //List<Car> list = new List<Car>();
            //list.Add(new Car() { Brand = "BMW", Model = "M5" });
            //list.Add(new Car() { Brand = "Porsche", Model = "911" });
            //list.Add(new Car() { Brand = "Mercedes", Model = "GLS" });
            //list.RemoveAt(0);
            //list.Reverse();
            ////list.Clear();

            //for (int i = 0; i < list.Count; i++) {
            //    Console.WriteLine(list[i]);
            //}



            //Car car1 = new Car() {
            //    Model = "325",
            //    Brand = "BMW",
            //};
            //Car car2 = new Car() {
            //    Model = "325",
            //    Brand = "BMW",
            //};

            //object obj = car1;

            ////bool isEquals = car1.Equals(car2);
            ////bool isEquals = car1.Equals(obj);

            //Console.WriteLine(isEquals);

            //object obj = car1;

            //Console.WriteLine(car2.GetHashCode());
            //Console.WriteLine(car1.GetHashCode());
            //Console.WriteLine(obj.GetHashCode());



            //int num = 123;
            //string numStr = num.ToString();
            //Console.WriteLine(numStr);

            //Car car = new Car() {
            //    Model = "325",
            //    Brand = "BMW",
            //};

            //string carStr = car.ToString();
            //Console.WriteLine(carStr);


            // boxing
            //Func(12.5);
            //Func(5);

            //int num = 123;
            //string str = new string("qwerty");

            //object obj = num;
            //obj = str;

            //Exception ex = new ArgumentNullException();
            //bool check = ex is ArgumentNullException;
            //Console.WriteLine(check);



            //object obj = "123456";

            //int num1 = (int)obj;
            //var num2 = obj as int;

            //Console.WriteLine(num1);




            //object obj = new Exception("Test error!");

            //Exception ex = obj as Exception;
            //Program ex = (Program)obj;
            //Program ex = obj as Program;

            //if(ex != null) {
            //    
            //}

            //Console.WriteLine(ex == null);


            //object[] objs = {
            //    123,
            //    "qwe",
            //    'c',
            //    true,
            //    new Program(),
            //    new Car() {
            //        Model = "325",
            //        Brand = "BMW",
            //    },
            //};

            //for (int i = 0; i < objs.Length; i++) {
            //    Console.WriteLine(objs[i]);
            //}
        }

        public static void Func(object obj) {
            // if int: num * 2
            // else if string: "strstr"

            // unboxing
            if (obj is int) {
                int num = (int)obj;
                Console.WriteLine($"{nameof(Int32)}: {num * 2}");
            }
            else if (obj is double) {
                double num = (double)obj;
                Console.WriteLine($"{nameof(Double)}: {num}{num}");
            }
        }
    }
}
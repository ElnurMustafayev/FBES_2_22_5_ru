namespace StaticApp {
    public static class MyStaticClass {
        public static int num;

        public static void Init() {
            num = new Random().Next();
        }

        //public MyStaticClass(string str) { }

        static MyStaticClass() {
            Console.WriteLine("CTOR");
            num = 777;
        }

        public static void StaticMethod() => Console.WriteLine(num);
        //public void Func() => StaticMethod();
    }
}

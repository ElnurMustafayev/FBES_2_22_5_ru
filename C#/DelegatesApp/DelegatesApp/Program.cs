namespace DelegatesApp {
    public class Program {
        public int Num = 123;

        public void ShowNum() => Console.WriteLine(this.Num);

        delegate void MyDelegate();
        delegate bool NumberCheck(int num);

        public static void SayHello() => Console.WriteLine("Hello World!");
        public static void SayGoodbye() => Console.WriteLine("Goodbye World!");
        public static bool IsPositive(int num) {
            Console.WriteLine("IsPositive");
            return num > 0;
        }
        public static bool IsNegative(int num) {
            Console.WriteLine("IsNegative");
            return num < 0;
        }

        static void Main() {
            if(false) {
                var obj = new Program();
                MyDelegate del = obj.ShowNum;

                del.Invoke();
            }

            if (false) {
                NumberCheck numberCheck = IsNegative;
                numberCheck += IsPositive;

                bool result = numberCheck.Invoke(15);

                Console.WriteLine(result);
            }

            if(false) {
                MyDelegate del1 = SayHello;
                del1 += SayGoodbye;

                del1.Invoke();
                del1();

                NumberCheck del2 = IsPositive;
            }
        }
    }
}
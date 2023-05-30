using static DelegatesApp.Delegates;

namespace DelegatesApp {
    public class Delegates {
        public int Num = 123;

        public delegate void MyDelegate();
        public delegate bool NumberCheck(int num);
        public delegate bool CheckerDel<T>(T param);


        public void ShowNum() => Console.WriteLine(this.Num);


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

        //public static List<int> GetPositiveNumbers(List<int> numbers) {
        //    var positiveNumbers = new List<int>();

        //    foreach (var number in numbers) {
        //        if(number > 0)
        //            positiveNumbers.Add(number);
        //    }

        //    return positiveNumbers;
        //}

        //public static List<int> GetNegativeNumbers(List<int> numbers) {
        //    var positiveNumbers = new List<int>();

        //    foreach (var number in numbers) {
        //        if (number < 0)
        //            positiveNumbers.Add(number);
        //    }

        //    return positiveNumbers;
        //}


        public static List<T> GetNumbers<T>(List<T> numbers, CheckerDel<T> numberCheck) {
            var resultNumber = new List<T>();

            foreach (T number in numbers) {
                if (numberCheck.Invoke(number))
                    resultNumber.Add(number);
            }

            return resultNumber;
        }

        public delegate T2 MyGenericDel<T1, T2, T3>(T1 param1, T3 param2);

        public static double Test(int num, bool check) {
            Console.WriteLine("Test");
            return 0;
        }

        public static double qwerty(int num, bool check) {
            Console.WriteLine("qwerty");
            return 0;
        }

        static void Mainnn() {
            if(false) {
                MyGenericDel<int, double, bool> del = Test;
                del += qwerty;
                del += Test;
                del += qwerty;
                del += qwerty;
                del -= qwerty;

                del.Invoke(123, true);
            }


            if(false) {
                var numbers = new List<int>() {
                    12,0,-35,46,-2
                };
                var positiveNumbers = GetNumbers<int>(numbers, IsPositive);

                foreach (var number in positiveNumbers) {
                    Console.WriteLine(number);
                }
            }



            if(false) {
                CheckerDel<int> del = IsPositive;
            }




            if(false) {
                var obj = new Delegates();
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
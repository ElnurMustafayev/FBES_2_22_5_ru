using System.Collections.Generic;

namespace DelegatesApp;

public class Lambdas {
    public delegate void FuncDel();
    public delegate void FuncDel<T>(T obj);
    public delegate void FuncDel<T1, T2>(T1 obj1, T2 obj2);

    public static void DoSomething1() {
        Console.WriteLine($"Something");
    }
    public static void DoSomething2(int num) => Console.WriteLine($"Result: {num}");
    public static void DoSomething3(int num1, double num2) {
        Console.WriteLine($"Result: {num1} {num2}");
    }

    //public static void DoAction(Action<int> action1, Action<bool> action2, Action<string, string> action3) {
    //    action2.Invoke(true);
    //    action1.Invoke(12);
    //    action3.Invoke("qwe", "qweqwe");
    //}

    public static bool CheckName(string name) {
        if (string.IsNullOrEmpty(name))
            return false;

        foreach (char symbol in name) {
            if (char.IsLetter(symbol) == false)
                return false;
        }

        return true;
    }

    public static int Minus(string first, string second) {
        if (string.IsNullOrWhiteSpace(first) || string.IsNullOrWhiteSpace(second))
            return 0;

        return first.Length - second.Length;
    }

    public static void Main() {
        if(false) {
            //Action action1 = () => Console.WriteLine("Hello World");
            //action1.Invoke();

            //Action<int, double> action2 = (x, y) => Console.WriteLine(x);
            //action2.Invoke(1, 2);

            //Func<int, string> GetNumberAsString = (num) => num.ToString();

            //var numberStr = GetNumberAsString.Invoke(123);
            //Console.WriteLine(numberStr);


            Func<string, string, int> MinusForStrings = (word1, word2) => {
                if (string.IsNullOrWhiteSpace(word1) || string.IsNullOrWhiteSpace(word2))
                    return 0;

                return word1.Length - word2.Length;
            };

            var result = MinusForStrings.Invoke("text", "qwerty");
            Console.WriteLine(result);
        }




        if(false) {
            Action<string> action = delegate (string text) {
                Console.WriteLine("Anonimous method!");
                Console.WriteLine($"Message: \"{text}\"");
            };

            action.Invoke("Test");



            Predicate<int> isPositive = delegate (int num) {
                return num > 0;
            };

            var result = isPositive.Invoke(0);
            Console.WriteLine(result);



            Func<decimal, int, string> func = delegate (decimal num, int count) {
                return $"{num}-{count}";
            };

            Console.WriteLine(func.Invoke(12,45));
        }

        if(false) {
            //Action<int> action1 = new Action<int>(DoSomething2);
            //Action<int> action2 = DoSomething2;

            Action action3 = delegate () {
                Console.WriteLine("The First");
            };

            action3 += delegate () {
                Console.WriteLine("The Second");
            };

            action3.Invoke();
        }

        if(false) {
            Func<string, string, int> func = Minus;
            var result = func.Invoke("test", "    ");
            Console.WriteLine(result);

            Func<string, bool> func1 = CheckName;
            Predicate<string> predicate = CheckName;
        }

        if(false) {
            Predicate<string> predicate = CheckName;
            Console.WriteLine(predicate.Invoke("test"));
            Console.WriteLine(predicate.Invoke("bob777"));
            Console.WriteLine(predicate.Invoke("qw2erty**"));
        }

        if(false) {
            // Action

            //Action action = DoSomething1;
            //Action<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int> action;

            //Action<int, double> action = DoSomething3;
        }


        //FuncDel<int> action = DoSomething2;
    }
}
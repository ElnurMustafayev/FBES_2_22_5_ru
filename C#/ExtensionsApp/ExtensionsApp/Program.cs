namespace ExtensionsApp;

using ExtensionsApp.Extensions;
using ExtensionsApp.Models;

public class MyClass {
    public string Name { get; set; } = "qwerty";
    public void Func1() { }
    public void Func2() { }
}

public static class MyClassExtensions {
    // extension methods
    public static void Func3(this MyClass obj) {
        obj.Name = "test";
    }

    public static void FuncWithParams(this MyClass obj, int num, params string[] names) {
        Console.WriteLine(obj.Name);
        for (int i = 0; i < num; i++) {
            foreach (var name in names) {
                Console.WriteLine(name);
            }
        }
    }

    public static int GetSum(this DateTime dateTime) {
        return dateTime.Year + dateTime.Month + dateTime.Day;
    }

    public static string? Capitalize(this string name, bool throwIfWrong = false) {
        var formatException = new FormatException($"{nameof(name)} is in incorrect format. Value: '{name}'");

        if (string.IsNullOrEmpty(name)) {
            return throwIfWrong ? throw formatException : null;
        }

        foreach (var symbol in name) {
            if (char.IsLetter(symbol) == false)
                return throwIfWrong ? throw formatException : null;
        }

        return char.ToUpper(name[0]) + name[1..].ToLower();
    }

    public static bool Has<T>(this T[] arr, T value) {
        foreach (var item in arr) {
            if (item.Equals(value))
                return true;
        }
        return false;
    }

    // non-extension methods
    public static void Func3(int num) {
    }
}

public class Program {
    private static void Main() {
        //var collection = new List<int>();
        //collection.Add(1);
        //collection.Add(2);
        //collection.Add(3);

        //collection.ToArray();





        //var result = new int[5] {1,2,3,4,5}.Has(4);
        //Console.WriteLine(result);




        //var result = "bob".Capitalize();
        //Console.WriteLine(result);




        // "bob".capitalize(throwIfWrong: bool = false) => "Bob"





        //DateTime dateTime = DateTime.Now;
        //Console.WriteLine(dateTime.GetSum());







        //MyClass obj = new MyClass();
        //obj.Name = "test";
        //obj.FuncWithParams(2, "one", "two", "three");



        //User user = new User() {
        //    Name = "Bob",
        //    Surname = "Marley",
        //    BirthDate = new DateTime(1964, 5, 5),
        //};

        //user.Show();
        //Console.WriteLine($"Check: {user.Check()}");







        //MyClass obj = new MyClass();
        //// obj.Func1(); == MyClass::Func1(obj);

        //Console.WriteLine(obj.Name);
        //obj.Func3();
        //Console.WriteLine(obj.Name);


        // User
        // + Name
        // + Surname
        // + BirthDate

        // add extension methods:
        // void Show()
        // bool Check();

    }
}
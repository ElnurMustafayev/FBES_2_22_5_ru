using System.Text.Json;

namespace NullableApp;

public class MyNullable<T> {
    public T Value;

    public MyNullable(T value) {
        this.Value = value;
    }
}

public class Person {
    public string? Name { get; set; }
    public int? Age { get; set; }

    public Person Func1() => this;
    public Person? Func2() => null;

    public override string ToString() => $"{Name} {Age}";
}

public struct Currency {
    public string Name { get; set; }
    public double Rate { get; set; }

    public void Test() { }
}

public class Program {
    public static bool IsPositive(int? num) {
        return num > 0;
    }

    public static double? GetMoney() {
        return Random.Shared.Next(0, 2) == 1 ? 123.5 : null;
    }

    public string? GetName() {
        return null;
    }


    public static void Test(string? str) {
        var res = str?.Trim().ToLower().ToLower();
        Console.WriteLine(res);
    }

    private static void Main() {
        //Person? person = null;

        //Console.WriteLine(person?.Func2().Func1().Func1());



        //Person? person = new Person() {
        //    Name = "Elnur",
        //    Age = null,
        //};

        //Console.WriteLine(person);

        //var json = JsonSerializer.Serialize(person);
        //Console.WriteLine(json);    //{"Name":"Bob","Age":null}
        //var result = JsonSerializer.Deserialize<Person>(json);

        //Console.WriteLine(result);

        //person = null;

        //Console.WriteLine(person?.Name?.ToLower());
        //Console.WriteLine(person?.Name.ToLower());



        //Test("Qwerty");




        ////string result = str == null ? "Unknown" : str.ToLower();

        //// nullcheck: ?.
        //var result = str?.ToLower();

        //Console.WriteLine($"Is null: {result == null}");
        //Console.WriteLine($"Value: {result}");




        //if (str == null) {
        //    throw new NullReferenceException();
        //}

        //var result = str.ToLower();
        //Console.WriteLine(result);






        //if(string.IsNullOrWhiteSpace(str) == false) {
        //    var result = str.ToLower();

        //    Console.WriteLine(result);
        //}




        //Currency? currency = null;
        //currency.GetValueOrDefault().Test();




        //double? money = GetMoney();

        //if(money is not null) {
        //    var result = money.Value.CompareTo(12.5);
        //    Console.WriteLine(result);
        //}








        //int? num = 123;

        ////if(num is int?) {
        ////if(num is Nullable<int>) {

        ////if(num != null) {
        ////if(!num.HasValue) {
        //if(num is not null) {
        //    num += 100;
        //    Console.WriteLine(num);
        //}








        //string? str = null;
        //Console.WriteLine(str);

        //Nullable<int> num1 = null;
        //int? num1 = null;
        //int val = num1.HasValue ? num1.Value : default;
        ////int val = num1.GetValueOrDefault();

        //Console.WriteLine(val);

        //if (num1.HasValue) {
        //    Console.WriteLine(num1.Value);
        //}
        //else {
        //    Console.WriteLine("No Value!");
        //}

        //int? num2 = null;

        //Console.WriteLine(num);








        //Console.WriteLine(IsPositive(10));
        //Console.WriteLine(IsPositive(null));





        //Person person = new Person() {
        //    Name = "Bob",
        //    Age = null,
        //};








        //int num = null;

        //string? str = null;

        //Console.WriteLine(str.ToString());

        //string name = "Arzu";
        //int? age = null;


        //MyNullable<int> age = new MyNullable<int>(10);
        //MyNullable<double> money = null;
        //int age = null;

        //int age = default;
        //int age = 0;
    }
}

namespace PartialClassApp;

public partial class MyPartialClass {
    public int Num { get; set; }

    public MyPartialClass(int num) {
        Num = num;
        Console.WriteLine(PI);
    }
}

public partial class MyPartialClass {
    public override string ToString() {
        return $"Num: {this.Num}";
    }

    public readonly string PI = "3.14";
}


public class Program {
    private static void Main() {
        var obj = new MyPartialClass(123);
        Console.WriteLine(obj);
    }
}
namespace ReflectionApp;

using System.Reflection;

class Test
{
    public int test = 100;
    public MyClass obj = new MyClass(true);
    public bool? flag = false;
}

public class MyClass
{
    public int num = 100;
    public string Text { get; set; }
    public MyClass(bool flag) => Console.WriteLine("Parameterized ctor");
    public MyClass() => Console.WriteLine("Parameterless ctor");
    public void Method(bool test)
    {
        Console.WriteLine(test);
        Console.WriteLine("Hello World!");
        Console.WriteLine(this.num);
    }
}

public class Program
{
    static void Main()
    {
        //Assembly currentAssembly = Assembly.GetExecutingAssembly();

        //var types = currentAssembly.GetTypes()
        //    .Where(t => )

        //Type t = typeof(object);
        //Console.WriteLine(t.Assembly.GetTypes().Count());
        //Console.WriteLine(t.Assembly.GetTypes().Count());

        //new MyClass(true).GetType();
        //typeof(MyClass)
        //foreach (var item in Assembly.GetExecutingAssembly().GetTypes())
        //{
        //    Console.WriteLine(item);
        //}



        //string typeFullname = Console.ReadLine();
        //Type t = Assembly.GetExecutingAssembly().GetType(typeFullname);
        //Console.WriteLine(t.FullName);


        //Type t = Assembly.GetExecutingAssembly().GetType("ReflectionApp.Test");
        ////Test obj = new Test();
        //var obj = Activator.CreateInstance(t);

        //foreach (var field in t.GetFields())
        //{
        //    var @value = field.GetValue(obj);
        //    Console.WriteLine($"{field.FieldType.Name} {field.Name} = {@value}");
        //}


        Type t = typeof(MyClass);
        MethodInfo mi = t.GetMethod("Method");
        object obj = Activator.CreateInstance(t, args: true);

        mi.Invoke(obj, parameters: new object[] { false });
    }
}
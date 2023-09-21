namespace AnonimousClassesApp;

public class User {
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Birthdate { get; set; }
    public bool IsMarried { get; set; }

    public override string ToString() => $"{Id} {Name} {Birthdate} {IsMarried}";
}

public class Program
{
    private static void Main(string[] args)
    {
        //var user = new User();

        //Console.WriteLine(user);



        var obj1 = new
        {
           num = 1,
           str = "Hello World!",
        };

        var obj2 = new
        {
           num = 1,
           str = "Hello World!",
           temp = true
        };

        Console.WriteLine(obj1.GetType().Name);
        Console.WriteLine(obj2.GetType().Name);





        //IEnumerable<User> users = new List<User>()
        //{
        //    new User() { Id = 1, Name = "Bob", Birthdate = new DateTime(1987, 5, 5), IsMarried = true },
        //    new User() { Id = 2, Name = "Ann", Birthdate = new DateTime(2013, 4, 27), IsMarried = false },
        //    new User() { Id = 3, Name = "John", Birthdate = new DateTime(1997, 1, 1), IsMarried = false },
        //};

        //var result = users
        //    .Where(u => u.IsMarried == false)
        //    .Select(u => new {
        //        UserId = u.Id, 
        //        Xolostyak = u.Name,
        //    });

        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);
        //}

        //int num = 100;

        //var obj = new
        //{
        //    num
        //};

        //Console.WriteLine(obj);

        //Console.WriteLine(new { test = 1 == 1 }.test.GetType().Name);
    }
}
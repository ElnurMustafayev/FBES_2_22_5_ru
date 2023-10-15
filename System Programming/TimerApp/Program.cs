namespace TimerApp;

public class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public User(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public override string ToString() => $"{FirstName} {LastName}";
}

public class Program {
    static void Main() {
        //Timer timer = new Timer(
        //    callback: (obj) => Console.WriteLine("<-- tick -->"),
        //    state: null,
        //    dueTime: 0,
        //    period: 1000);

        //while (true)
        //{
        //    Thread.Sleep(200);
        //    Console.WriteLine("Main");
        //}



        //User user = new User("Bob", "Marley");

        //Timer timer = new Timer(
        //    callback: (obj) => {
        //        if(obj is User user)
        //        {
        //            user.FirstName = Guid.NewGuid().ToString();
        //        }
        //    },
        //    state: user,
        //    dueTime: 1000,
        //    period: 1000);

        //while(true)
        //{
        //    Console.WriteLine(user);
        //    Console.ReadKey();
        //}
    }
}
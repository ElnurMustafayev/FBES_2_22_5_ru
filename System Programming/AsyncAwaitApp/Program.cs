namespace AsyncAwaitApp;

public class User
{
    public string Name { get; set; }
    public string Surname { get; set; }
}

public class Program
{
    public static Task MyMethodAsync()
    {
        var task = new Task(() =>
        {
            Thread.Sleep(3000);
            Console.WriteLine("Hello World!");
        });

        task.Start();

        return task;
    }

    //public static async Task MyClientCode()
    //{
    //    await MyMethodAsync();
    //}

    public static Task Func(int ms)
    {
        return Task.Run(() =>
        {
            Thread.Sleep(ms);
            Console.WriteLine(ms);
        });
    }

    public static Task<int> Func(int ms, int result)
    {
        return Task.Run(() =>
        {
            Thread.Sleep(ms);
            Console.WriteLine(ms);

            return result;
        });
    }

    public static async Task AsyncFunc()
    {
        Console.WriteLine("start");
        await Func(2000);
        Console.WriteLine("middle");
        var result = await Func(1000, 777);
        Console.WriteLine("value: " + result);
        Console.WriteLine("middle");
        await Func(3000);
        Console.WriteLine("end");
    }

    public static async Task<User> FuncWithReturn()
    {
        //return await Task.Run<User>(() =>
        //{
        //    Thread.Sleep(1000);

        //    return new User()
        //    {
        //        Name = "Elnur",
        //        Surname = "Mustafayev",
        //    };
        //});

        await Task.Delay(1000);

        return new User()
        {
            Name = "Elnur",
            Surname = "Mustafayev",
        };
    }

    public static async void PrintUserName()
    {
        var result = await FuncWithReturn();

        Console.WriteLine(result.Name);
    }

    public static void Main()
    {
        PrintUserName();

        for (int i = 0; ;i++)
        {
            Thread.Sleep(100);
            Console.WriteLine(i);
        }

        //var res1 = FuncWithReturn().Result;
        //var res2 = await FuncWithReturn();


        //var obj = await FuncWithReturn();

        //var obj = await FuncWithReturn();

        //AsyncFunc();

        //while(true)
        //{
        //    Thread.Sleep(200);
        //    Console.WriteLine("Main");
        //}



        //Console.WriteLine("Start");
        //await MyMethodAsync();
        //Console.WriteLine("End");

        //var task = MyMethodAsync();
        //task.Wait();
    }
}
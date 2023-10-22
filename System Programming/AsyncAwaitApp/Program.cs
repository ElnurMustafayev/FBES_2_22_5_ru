namespace AsyncAwaitApp;

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

    public static async Task Main()
    {
        AsyncFunc();

        while(true)
        {
            Thread.Sleep(200);
            Console.WriteLine("Main");
        }



        //Console.WriteLine("Start");
        //await MyMethodAsync();
        //Console.WriteLine("End");

        //var task = MyMethodAsync();
        //task.Wait();
    }
}
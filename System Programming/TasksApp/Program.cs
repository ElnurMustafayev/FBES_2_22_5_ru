namespace MyNamespace;

using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;

public class User
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("surname")]
    public string? Surname { get; set; }
}

public class Program
{
    public static Task<int> GetUsersCountAsync()
    {
        return Task<int>.Run(() =>
        {
            var usersJson = File.ReadAllText("assets/users.json");
            var users = JsonSerializer.Deserialize<IEnumerable<User>>(usersJson);
            Thread.Sleep(2000);
            return users?.Count() ?? 0;
        });
    }

    public static int GetUsersCount()
    {
        int result = 0;

        var thread = new Thread(() =>
        {
            var usersJson = File.ReadAllText("assets/users.json");
            var users = JsonSerializer.Deserialize<IEnumerable<User>>(usersJson);
            Thread.Sleep(2000);
            var count = users?.Count() ?? 0;
            result = count;
        });

        thread.Start();
        thread.Join();

        return result;
    }

    public static Task CountAsync(int start, int end)
    {
        //var task = new Task(() =>
        //{
        //    for (int i = start, j = 1; i < end; i++, j++)
        //    {
        //        Console.WriteLine($"{j}. {i}");
        //        Thread.Sleep(1000);
        //    }
        //});

        //task.Start();

        //return task;
        return Task.Run(() =>
        {
            for (int i = start, j = 1; i < end; i++, j++)
            {
                Console.WriteLine($"{j}. {i}");
                Thread.Sleep(1000);
            }
        });
    }

    public static void Main()
    {


        //var task = Task.Run(() =>
        //{
        //    Console.WriteLine("1 start");
        //    Thread.Sleep(1000);
        //    Console.WriteLine("1 end");
        //});

        //task.ContinueWith((t) =>
        //{
        //    Console.WriteLine("2 start");
        //    Thread.Sleep(2000);
        //    Console.WriteLine("2 end");
        //});

        //Console.ReadKey();

        //task.Start();





        //var tasks = new Task[]
        //{
        //    Task.Run(() =>
        //    {
        //        Thread.Sleep(1000);
        //        Console.WriteLine("1");
        //    }),
        //    Task.Run(() =>
        //    {
        //        Thread.Sleep(2000);
        //        Console.WriteLine("2");
        //    }),
        //    Task.Run(() =>
        //    {
        //        Thread.Sleep(5000);
        //        Console.WriteLine("5");
        //    })
        //};

        //Task.WaitAll(tasks);
        //Task.WaitAny(tasks);



        //var result = Task.Run(() => 123.ToString());

        //Console.WriteLine(result.Result);





        //var randomizerTask = new Task<int>(() =>
        //{
        //    Thread.Sleep(1000);
        //    Console.WriteLine("Test");
        //    return Random.Shared.Next(700, 800);
        //});
        //randomizerTask.Start();
        ////randomizerTask.Wait();

        //Console.WriteLine(randomizerTask.Result);
        //Console.WriteLine(randomizerTask.Result);
        //Console.WriteLine(randomizerTask.Result);


        //randomizerTask.Wait();




        //var task = CountAsync(5, 10);

        //task.Start();
        //task.Wait();



        //var task = new Task(() =>
        //{
        //    Thread.Sleep(100);
        //    Console.WriteLine("Hello from Task 1!");
        //    Thread.Sleep(100);
        //    Console.WriteLine("Hello from Task 2!");
        //    Thread.Sleep(100);
        //    Console.WriteLine("Hello from Task 3!");
        //});

        //task.RunSynchronously();

        //task.Start();
        //task.Wait();

        //Console.ReadKey();



        //var count = GetUsersCount();
        //Console.WriteLine($"Users' count: {count}");
    }
}
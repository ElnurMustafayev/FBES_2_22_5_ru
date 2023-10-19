using System.Threading.Channels;

namespace ThreadPoolApp;

public class Program
{
    static void Main()
    {
        if (false)
        {
            //ThreadPool.GetAvailableThreads
            //ThreadPool.GetMaxThreads
            //ThreadPool.GetMinThreads
            //ThreadPool.SetMaxThreads
            //ThreadPool.SetMinThreads
        }

        if (false)
        {
            ThreadPool.QueueUserWorkItem((obj) =>
            {
                var threadId = Thread.CurrentThread.ManagedThreadId;
                Console.WriteLine($"Thread ID: {threadId}");
            });

            Thread.Sleep(1000);

            ThreadPool.QueueUserWorkItem((obj) =>
            {
                Console.WriteLine("Thread 2");
                var threadId = Thread.CurrentThread.ManagedThreadId;
                Console.WriteLine($"Thread ID: {threadId}");
            });

            Thread.Sleep(1000);

            ThreadPool.QueueUserWorkItem((obj) =>
            {
                Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId}");
                Console.WriteLine("END!");
            });

            Console.ReadKey();
        }

        if (false)
        {
            ThreadPool.QueueUserWorkItem<int>(
                callBack: (obj) => Console.WriteLine(obj), 
                state: 777, 
                preferLocal: true);

            Console.ReadKey();
        }

        if(false)
        {
            WaitCallback waitCallback = delegate (object? obj) {
                Console.WriteLine("Start");
                Console.WriteLine(obj);
                Console.WriteLine("End");
            };
            ThreadPool.QueueUserWorkItem(waitCallback, 123);

            Console.ReadKey();
        }
    }
}
using System.Threading;

namespace ThreadsApp;

public class Program {
    static void Main() {
        if(false)
        {
            ThreadStart threadStart = () =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Hello From Thread -- 1");
                Thread.Sleep(1000);
                Console.WriteLine("Hello From Thread -- 2");
                Thread.Sleep(1000);
                Console.WriteLine("Hello From Thread -- 3");
            };
            Thread thread = new Thread(threadStart);
            thread.IsBackground = false;

            thread.Start();
            Console.WriteLine("Hello From Main");
            //Thread.Sleep(100);
        }

        if(false)
        {
            new Thread((obj) =>
            {
                while (true)
                {
                    Console.WriteLine(obj);
                    Thread.Sleep(1000);
                }
            })
            {
                IsBackground = true
            }.Start(parameter: 777);

            Console.ReadKey();
        }

        if(false)
        {
            Thread thread1 = new Thread(() =>
            {
                while (true)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("Thread 1");
                }
            })
            {
                IsBackground = true,
            };

            Thread thread2 = new Thread(() =>
            {
                while (true)
                {
                    Thread.Sleep(500);
                    Console.WriteLine("Thread 2");
                }
            })
            {
                IsBackground = true,
            };

            thread1.Start();
            thread2.Start();

            Console.ReadKey();
        }

        if(false)
        {
            Thread thread = new Thread(() =>
            {
                var anotherThread = Thread.CurrentThread;
                Console.WriteLine($"Another Thread Id: {anotherThread.ManagedThreadId}");
            });

            thread.Start();

            Thread generalThread = Thread.CurrentThread;
            Console.WriteLine($"Main Thread Id: {generalThread.ManagedThreadId}");
        }
    }
}
namespace ThreadsApp;

using System.Threading;

public class Program {
    static void Main() {
        if (true)
        {
            Thread thread1 = new Thread(() =>
            {
                Console.WriteLine("Thread 1 start");
                Thread.Sleep(3000);
                Console.WriteLine("Thread 1 done");
            });

            Thread thread2 = new Thread(() =>
            {
                Console.WriteLine("Thread 2 start");
                thread1.Start();
                Console.WriteLine("Thread 2 middle");
                Console.WriteLine("Thread 2 middle");
                Console.WriteLine("Thread 2 middle");
                thread1.Join();
                Thread.Sleep(1000);
                Console.WriteLine("Thread 2 done");
            });

            thread2.Start();

            while (true)
            {
                Console.WriteLine("MAIN");
                Thread.Sleep(1000);
            }

            //thread1.Start();
            //thread1.Join();

            //thread2.Start();
        }

        if (false)
        {
            CancellationTokenSource source = new CancellationTokenSource();

            Thread thread = new Thread((obj) =>
            {
                if (obj is CancellationToken token)
                {
                    while (true)
                    {
                        if (token.IsCancellationRequested)
                            break;

                        Thread.Sleep(1000);
                        Console.WriteLine("thread");
                    }
                }
            });

            thread.Start(source.Token);

            Console.WriteLine("Press any key to stop thread...");
            Console.ReadKey();

            source.Cancel();

            Console.WriteLine("Thread stopped!");

            Console.ReadKey();
        }

        if (false)
        {
            Thread thread = new Thread(() =>
            {
                while (true)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("thread");
                }
            });

            thread.Start();

            Console.ReadKey();

            //thread.Suspend();
            //thread.Abort();
            //thread.Interrupt();

            Console.WriteLine("Thread stopped!");

            Console.ReadKey();
        }

        if(false)
        {
            ParameterizedThreadStart printNumberRange = (obj) =>
            {
                if (obj is null || obj is not Range)
                    return;

                var range = (Range)obj;

                for (int i = range.Start.Value; i < range.End.Value; i++)
                {
                    Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId}: {i}");
                }
            };

            Thread[] numberPrinters = new Thread[]
            {
                new Thread(printNumberRange),
                new Thread(printNumberRange),
            };

            foreach (var numberPrinter in numberPrinters)
            {
                numberPrinter.Start(new Range(0, Random.Shared.Next(5, 100)));
            }

            Console.ReadKey();
        }

        if(false)
        {
            ParameterizedThreadStart parameterizedThreadStart = (obj) =>
            {
                if (obj == null)
                    return;

                for (int i = 0; i < (int)obj; i++)
                {
                    Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId}: {i}");
                }
            };

            Thread thread1 = new Thread(parameterizedThreadStart);
            Thread thread2 = new Thread(parameterizedThreadStart);

            thread1.Start(5000);
            thread2.Start(4000);

            Console.ReadKey();
        }

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
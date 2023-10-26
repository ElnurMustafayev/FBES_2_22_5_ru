using System.Runtime.InteropServices.ObjectiveC;

namespace LockApp
{
    public class Program
    {
        static void Main()
        {
            // Monitor (lock)
            if(false)
            {
                object locker = new object();

                lock (locker)
                {
                    //Monitor.Enter(locker);

                    // code

                    //Monitor.Exit(locker);
                }
            }


            // Mutex (Semaphore)
            if(false)
            {
                //Mutex mutex = new Mutex(false, "MyMutex", out bool createdNew);

                //Console.WriteLine($"Mutex created: {createdNew}");
                //mutex.WaitOne();
                //Console.WriteLine("Mutex opened");
                //Console.ReadKey();
                //mutex.ReleaseMutex();
                //Console.WriteLine("Mutex released");




                //Semaphore semaphore = new Semaphore(2, 5, "MySemaphore", out bool createdNew);
                //Console.WriteLine($"Mutex created: {createdNew}");
                //semaphore.WaitOne();
                //Console.WriteLine("Semaphore opened");
                //Console.ReadKey();
                //semaphore.Release();
                //semaphore.Release();
                //semaphore.Release();
                //semaphore.Release();
                //semaphore.Release();
                //Console.WriteLine("Semaphore released");
            }

            if(true)
            {
                Mutex mutex = new Mutex(false, "ThreadsProblem");
                object locker = new object();
                int num = 0;

                var task1 = Task.Run(() =>
                {
                    for (int i = 0; i < 1_000_000; i++)
                    {
                        lock (locker)
                        {
                            //Monitor.Enter(locker);
                            //mutex.WaitOne();
                            //Interlocked.Increment(ref num);
                            num++;
                            //mutex.ReleaseMutex();
                            //Monitor.Exit(locker);
                        }
                    }
                });

                var task2 = Task.Run(() =>
                {
                    for (int i = 0; i < 1_000_000; i++)
                    {
                        lock (locker)
                        {
                            //Monitor.Enter(locker);
                            //mutex.WaitOne();
                            //Interlocked.Increment(ref num);
                            num++;
                            //mutex.ReleaseMutex();
                            //Monitor.Exit(locker);
                        }
                    }
                });

                Task.WaitAll(task1, task2);
                Console.WriteLine(num);
            }
        }
    }
}
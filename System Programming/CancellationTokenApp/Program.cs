using System.Threading.Channels;

namespace CancellationTokenApp {
    public class Program {
        static void Main() {
            if(true)
            {
                CancellationTokenSource source = new CancellationTokenSource();
                
                Thread thread = new Thread((obj) =>
                {
                    if(obj is CancellationToken token)
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

            if(false)
            {
                CancellationTokenSource tokenSource = new CancellationTokenSource();

                CancellationToken token = tokenSource.Token;

                token.Register(() => Console.WriteLine("Cancelation Callback"));

                Console.WriteLine("Start");
                //Console.WriteLine(token.IsCancellationRequested); // False
                //token.ThrowIfCancellationRequested();
                tokenSource.Cancel();
                //token.ThrowIfCancellationRequested();
                //Console.WriteLine(token.IsCancellationRequested); // True
                Console.WriteLine("End");
            }
        }
    }
}
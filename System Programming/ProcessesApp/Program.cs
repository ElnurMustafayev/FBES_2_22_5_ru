namespace ProcessesApp;

using System.Diagnostics;

public class Program {
    static void Main(string[] args) {
        //Console.WriteLine("- - - START - - -");
        //foreach (string arg in args)
        //{
        //    Console.WriteLine(arg);
        //}
        //Console.WriteLine("- - - END - - -");

        //Process.Start("calc.exe");
        //Process.Start("mspaint.exe");

        //Process.Start("dotnet.exe");
        //Process.Start("dotnet-ef.exe");

        //Console.WriteLine("Start");
        //Process.Start(@"C:\Users\mustafayev_e\Desktop\Code\Code\bin\Debug\net7.0\Code.exe");
        //Thread.Sleep(1000);
        //Console.WriteLine("End");

        //Process.Start("notepad.exe");
        //Process.Start("notepad.exe", "Test.txt");
        //Process.Start(@"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe", 
        //    arguments: new List<string> {
        //        "https://github.com/ElnurMustafayev/FBES_2_22_5_ru",
        //        "https://www.youtube.com/watch?v=wC70XK-KgIo"
        //    });


        //var processStartInfo = new ProcessStartInfo()
        //{
        //    FileName = "mspaint.exe",
        //};
        ////Process.Start(processStartInfo);


        //var process = new Process()
        //{
        //    StartInfo = processStartInfo,
        //    EnableRaisingEvents = true,
        //    ProcessName = "test",
        //    PriorityClass = ProcessPriorityClass.Normal,
        //};
        //process.Exited += (s, e) =>
        //{
        //    Console.WriteLine("Process exited!");
        //};

        //process.Start();

        //Console.ReadKey();
        //process.Kill();

        //process.WaitForExit();

        // (infinity)
        // Input process name: _ 
        // Close process after pressing 'enter'



        //var processes = Process.GetProcesses();

        //var visualStudioProcess = processes.First(p => p.ProcessName == "devenv");

        //Console.WriteLine(visualStudioProcess.Id);
        //Console.WriteLine(visualStudioProcess);
        //visualStudioProcess.Kill();


        //Process.GetProcessById(123);


        //var proc = Process.GetCurrentProcess();
        //proc.PriorityClass = ProcessPriorityClass.High;
        //Console.WriteLine(proc.ProcessName);



        //foreach (var process in Process.GetProcesses())
        //{
        //    try
        //    {
        //        Console.WriteLine($"{process.ProcessName} - {process.PriorityClass} - {process.PagedMemorySize64}");
        //    }
        //    catch { }
        //}

        //Process.Start("ping.exe", "8.8.8.8");
    }
}
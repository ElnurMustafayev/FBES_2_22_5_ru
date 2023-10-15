using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DispatcherApp
{
    class ProcessInfo
    {
        public string? Name { get; set; }
        public long Ram { get; set; }

        public override string ToString() => $"{Name} ({Ram})";
    }


    public partial class MainWindow : Window
    {
        private Timer timer;
        public MainWindow()
        {
            InitializeComponent();

            //this.RefreshProcesses();

            this.timer = new Timer(
                callback: (obj) => {
                    Dispatcher.Invoke(() => {
                        this.MyProgressBar.Value++;
                    });
                },
                null, 1000, 100);
        }

        private void RefreshProcesses()
        {
            this.ProcessesListView.Items.Clear();
            var processes = Process.GetProcesses();

            foreach (var process in processes)
            {
                var processInfo = new ProcessInfo()
                {
                    Name = process.ProcessName,
                    Ram = process.PeakPagedMemorySize64
                };

                this.ProcessesListView.Items.Add(processInfo);
            }
        }
    }
}

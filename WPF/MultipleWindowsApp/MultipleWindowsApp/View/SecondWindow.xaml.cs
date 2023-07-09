using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MultipleWindowsApp {
    /// <summary>
    /// Interaction logic for SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window {
        private readonly Window parentWindow;

        public SecondWindow() {
            InitializeComponent();
        }

        public SecondWindow(Window parentWindow) : this() {
            this.parentWindow = parentWindow;
        }
    }
}

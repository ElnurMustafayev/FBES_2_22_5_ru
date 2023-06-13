using System;
using System.Windows;

namespace GettingStartedApp {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            //this.MyButton.MaxWidth = 500;
            //this.MyButton.Width = 300;

            //this.MyTextBox.Style

            this.MyTextBox.Text = Guid.NewGuid().ToString();
        }
    }
}

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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EventsApp {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            this.ClickMeButton.Background = new SolidColorBrush(Colors.Red);

            this.ClickMeButton.Click += (sender, evengArgs) => {
                Console.WriteLine($"Sender Type: {sender.GetType()}");
            };
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            this.ClickMeButton.Content = Guid.NewGuid().ToString();
            Console.WriteLine("Button content updated!");
        }

        private void MyTextBox_TextChanged(object sender, TextChangedEventArgs e) {
            if(sender is TextBox textbox) {
                if (string.IsNullOrWhiteSpace(textbox.Text))
                    return;

                this.ClickMeButton.Content = textbox.Text.Trim();
            }
        }

        private void CheckBox_Check(object sender, RoutedEventArgs e) {
            if(sender is CheckBox checkBox) {
                Console.WriteLine(checkBox.IsChecked);
                this.ClickMeButton.Visibility = checkBox.IsChecked == true ? Visibility.Visible : Visibility.Hidden;
                this.MyTextBox.Visibility = checkBox.IsChecked == true ? Visibility.Visible : Visibility.Hidden;
            }
        }
    }
}

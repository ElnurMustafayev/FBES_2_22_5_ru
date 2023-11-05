using System;
using System.Net;
using System.Net.Sockets;
using System.Windows;

namespace ClientApp
{
    public partial class MainWindow : Window
    {
        private TcpClient? tcpClient;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Join_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var hostname = this.HostnameTextBox.Text;
                var portStr = this.PortTextBox.Text;
                var nickname = this.NicknameTextBox.Text;

                if (string.IsNullOrWhiteSpace(hostname) || string.IsNullOrWhiteSpace(portStr))
                {
                    throw new ArgumentNullException($"{nameof(hostname)} or/and {nameof(portStr)} is empty!");
                }

                if (string.IsNullOrWhiteSpace(nickname))
                {
                    throw new ArgumentNullException($"{nameof(nickname)} is empty!");
                }

                if (int.TryParse(portStr, out int port) == false)
                {
                    throw new ArgumentException($"Port '{portStr}' must be a number!");
                }

                if (IPAddress.TryParse(hostname, out IPAddress? ip) == false || ip is null)
                {
                    throw new ArgumentException($"Hostname '{hostname}' is incorrect!");
                }

                this.tcpClient = new TcpClient();
                this.tcpClient.Connect(ip, port);

                this.Hide();
                var chatWindow = new ChatWindow(this.tcpClient, clientName: nickname);
                chatWindow.ShowDialog();
                this.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection failder", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}

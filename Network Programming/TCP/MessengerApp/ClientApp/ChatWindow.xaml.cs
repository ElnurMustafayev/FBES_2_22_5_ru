using System.IO;
using System.Net.Sockets;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using SharedLib.Models;

namespace ClientApp
{
    /// <summary>
    /// Interaction logic for ChatWindow.xaml
    /// </summary>
    public partial class ChatWindow : Window
    {
        private readonly string clientName;
        private readonly TcpClient tcpClient;
        private readonly StreamReader reader;
        private readonly StreamWriter writer;

        public ChatWindow(TcpClient tcpClient, string clientName)
        {
            this.tcpClient = tcpClient;
            this.clientName = clientName;
            this.reader = new StreamReader(tcpClient.GetStream());
            this.writer = new StreamWriter(tcpClient.GetStream());

            InitializeComponent();

            ListenMessagesAsync();
        }

        private async Task ListenMessagesAsync()
        {
            while(true)
            {
                var messageJson = await reader.ReadLineAsync();

                var message = JsonSerializer.Deserialize<SendMessageRequestModel>(messageJson);

                Dispatcher.Invoke(() =>
                {
                    this.MessagesListView.Items.Add(message);
                });
            }
        }

        private void SendMessage_Click(object sender, RoutedEventArgs e)
        {
            var message = this.MessageTextBox.Text;

            // validation
            if (string.IsNullOrEmpty(message))
                return;

            // prepare request
            var request = new SendMessageRequestModel()
            {
                From = this.clientName,
                Message = message
            };
            var requestJson = JsonSerializer.Serialize(request);

            // send request
            this.writer.WriteLine(requestJson);
            this.writer.Flush();

            // clear
            this.MessageTextBox.Text = string.Empty;
        }
    }
}

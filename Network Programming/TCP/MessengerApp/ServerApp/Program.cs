using SharedLib.Models;
using System.Net;
using System.Net.Sockets;
using System.Text.Json;

List<TcpClient> clients = new List<TcpClient>();
TcpListener listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 8080);

listener.Start();
Console.WriteLine("Server started...");

while (true)
{
    TcpClient tcpClient = await listener.AcceptTcpClientAsync();
    clients.Add(tcpClient);

    Console.WriteLine($"Client connected: '{tcpClient.Client.RemoteEndPoint}'");

    new Task(async () =>
    {
        NetworkStream networkStream = tcpClient.GetStream();
        var reader = new StreamReader(networkStream);

        while (true)
        {
            var clientRequestJson = await reader.ReadLineAsync();
            if (string.IsNullOrEmpty(clientRequestJson))
                continue;

            var clientRequest = JsonSerializer.Deserialize<SendMessageRequestModel>(clientRequestJson);

            if (clientRequest is null)
                continue;

            Console.WriteLine($"{clientRequest.From}: '{clientRequest.Message}'");

            // broadcast message
            foreach (var client in clients)
            {
                var writer = new StreamWriter(client.GetStream());
                await writer.WriteLineAsync(clientRequestJson);
                await writer.FlushAsync();
            }
        }
    }).Start();
}
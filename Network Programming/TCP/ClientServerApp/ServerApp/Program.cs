using System.Net;
using System.Net.Sockets;

TcpListener listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 8080);

listener.Start();
Console.WriteLine("Server started...");

while(true)
{
    TcpClient tcpClient = await listener.AcceptTcpClientAsync();

    Console.WriteLine($"Client connected: '{tcpClient.Client.RemoteEndPoint}'");

    new Task(async () =>
    {
        NetworkStream networkStream = tcpClient.GetStream();
        var writer = new StreamWriter(networkStream);

        while (true)
        {
            await writer.WriteLineAsync("Hello");
            await writer.FlushAsync();
        }
    }).Start();
}
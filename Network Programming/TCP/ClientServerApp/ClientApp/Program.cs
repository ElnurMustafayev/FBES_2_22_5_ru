using System.Net.Sockets;

TcpClient tcpClient = new TcpClient();

await tcpClient.ConnectAsync("localhost", 8080);

NetworkStream networkStream = tcpClient.GetStream();

var reader = new StreamReader(networkStream);

while(true)
{
    var message = await reader.ReadLineAsync();

    Console.WriteLine(message);
}
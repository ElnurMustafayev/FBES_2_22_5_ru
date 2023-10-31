using System.Net;
using System.Net.Sockets;

const string serverIp = "127.0.0.1";
const int port = 8080;

IPAddress address = IPAddress.Parse(serverIp);
IPEndPoint endPoint = new IPEndPoint(address, port);

Socket clientSocket = new Socket(
    addressFamily: AddressFamily.InterNetwork,
    socketType: SocketType.Stream,
    protocolType: ProtocolType.Tcp);

await clientSocket.ConnectAsync(endPoint);

var buffer = new byte[1024];
while(true)
{
    var size = clientSocket.Receive(buffer);

    byte[] messageInBytes = buffer[..size];

    foreach (var message in messageInBytes)
    {
        Console.Write(message + " ");
    }
    Console.WriteLine();
}
using System.Net;
using System.Net.Sockets;

const string serverIp = "127.0.0.1";
const int port = 8080;

IPAddress address = IPAddress.Parse(serverIp);
IPEndPoint endPoint = new IPEndPoint(address, port);



Socket serverSocket = new Socket(
    addressFamily: AddressFamily.InterNetwork,
    socketType: SocketType.Stream,
    protocolType: ProtocolType.Tcp);

serverSocket.Bind(endPoint);
serverSocket.Listen(backlog: 5);

Console.WriteLine($"Server started on {serverIp}:{port}");

Socket clientSocket = await serverSocket.AcceptAsync();

byte counter = 0;
while(true)
{
    counter++;
    await clientSocket.SendAsync(new byte[] { counter, counter, counter });

    Thread.Sleep(1000);
}
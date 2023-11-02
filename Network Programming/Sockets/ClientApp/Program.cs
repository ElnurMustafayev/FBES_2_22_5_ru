using System.Net;
using System.Net.Sockets;
using System.Text;

const string serverIp = "127.0.0.1";
const int port = 8080;

IPAddress address = IPAddress.Parse(serverIp);
IPEndPoint endPoint = new IPEndPoint(address, port);

Socket clientSocket = new Socket(
    addressFamily: AddressFamily.InterNetwork,
    socketType: SocketType.Stream,
    protocolType: ProtocolType.Tcp);

await clientSocket.ConnectAsync(endPoint);



byte[] buffer = new byte[1024];
ThreadPool.QueueUserWorkItem(async (obj) =>
{
    try
    {
        while (true)
        {
            var size = await clientSocket.ReceiveAsync(buffer);

            //if (size == 0)
            //{
            //    Console.WriteLine($@"Disconnected by Server!");
            //    break;
            //}

            var msg = Encoding.Unicode.GetString(buffer, 0, size);
            Console.WriteLine($@"Server: ""{msg}""");
        }
    }
    catch (SocketException)
    {
        Console.WriteLine("Disconnected from server!");
        Environment.Exit(0);
    }
    catch (Exception ex)
    {
        Console.WriteLine("System error: " + ex);
    }
}, null);



try
{
    Console.WriteLine("Write message and press 'enter' to send...\n\n");
    while (true)
    {
        string message = Console.ReadLine() ?? string.Empty;
        var messageInBytes = Encoding.Unicode.GetBytes(message);

        await clientSocket.SendAsync(messageInBytes);
    }
}
catch (SocketException)
{
    Console.WriteLine("Disconnected from server!");
    Environment.Exit(0);
}
catch (Exception ex)
{
    Console.WriteLine("System error: " + ex);
}
finally
{
    clientSocket.Dispose();
}
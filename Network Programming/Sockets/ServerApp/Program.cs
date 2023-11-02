using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

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

while(true)
{
    Socket clientSocket = await serverSocket.AcceptAsync();
    Console.WriteLine($"Client was connected {clientSocket.RemoteEndPoint}");

    ThreadPool.QueueUserWorkItem(async (socket) => {
        try
        {
            var buffer = new byte[1024];
            while (true)
            {
                var size = await socket.ReceiveAsync(buffer);
                var requestMessage = Encoding.Unicode.GetString(buffer, 0, size);

                Console.WriteLine($@"{socket.RemoteEndPoint}: ""{requestMessage}""");

                if(requestMessage.ToLower() == "hello")
                {
                    var responseMessage = "Hi";
                    var responseMessageInBytes = Encoding.Unicode.GetBytes(responseMessage);
                    await socket.SendAsync(responseMessageInBytes);

                    Thread.Sleep(1000);
                    //socket.Shutdown(SocketShutdown.Both);
                    //socket.Close();
                    //await socket.DisconnectAsync(false);
                    break;
                }
            }
        }
        catch (SocketException)
        {
            Console.WriteLine($"Client {socket.RemoteEndPoint} disconnected!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"System error in {socket.RemoteEndPoint} client.\n{ex}");
        }
    }, clientSocket, false);
}
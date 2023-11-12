using System.Net;
using System.Net.Sockets;
using System.Text;

UdpClient client = new UdpClient(8000);
const int packetLimit = 10_000; 

const string endMessage = "Image sent!";
var endMessageInBytes = Encoding.Unicode.GetBytes(endMessage);

while(true) {
    var imageInBytes = await File.ReadAllBytesAsync("Data/cat3.jpg");

    for (int packetCounter = 0; true; packetCounter++)
    {
        byte[] currentPacketInBytes = imageInBytes
            .Skip(packetCounter * packetLimit)
            .Take(packetLimit)
            .ToArray();

        if(currentPacketInBytes.Length == 0) {
            await client.SendAsync(endMessageInBytes, "localhost", 8080);
            System.Console.WriteLine(endMessage);
            break;
        }

        await client.SendAsync(currentPacketInBytes, "localhost", 8080);
        //Thread.Sleep(1);
    }
    
    Thread.Sleep(1000);

    //System.Console.WriteLine(imageInBytes.Length / packetLimit);
    //await client.SendAsync(imageInBytes, "localhost", 8080);
}



// send text message
if(false) {
    var message = "Hello World!";

    var messageInBytes = Encoding.Unicode.GetBytes(message);

    await client.SendAsync(messageInBytes, "localhost", 8080);
}

//var endpoint = new IPEndPoint(IPAddress.Parse("172.10.10.5"), 8080);
//await client.SendAsync(messageInBytes, messageInBytes.Length, endpoint);
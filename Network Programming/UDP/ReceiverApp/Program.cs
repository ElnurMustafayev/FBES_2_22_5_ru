using System.Net.Sockets;
using System.Text;

UdpClient client = new UdpClient(8080);
System.Console.WriteLine("Udp Client started!");
const string endMessage = "Image sent!";
var endMessageInBytes = Encoding.Unicode.GetBytes(endMessage);

List<byte> imageInBytes = new List<byte>(capacity: 1024);

while(true) {
    for (int i = 0; true; i++)
    {
        var result = await client.ReceiveAsync();
        var messageInBytes = result.Buffer;

        if(messageInBytes.Length == endMessageInBytes.Length 
            && Encoding.Unicode.GetString(messageInBytes) == endMessage) {
            var filename = $"Data/{Guid.NewGuid()}.jpg";

            File.WriteAllBytes(filename, imageInBytes.ToArray());
            System.Console.WriteLine($"{filename} created! packets count: {i}");
            break;
        }

        imageInBytes.AddRange(messageInBytes);

        //System.Console.WriteLine($"Packet #{i} received!");
    }
}



//while(true) {
    //File.WriteAllBytes($"Data/{Guid.NewGuid()}.png", result.Buffer);
    //System.Console.WriteLine($"client '{result.RemoteEndPoint}' sent file");



    //var messageInBytes = result.Buffer;
    // var messageTxt = Encoding.Unicode.GetString(messageInBytes);
    // System.Console.WriteLine($"{result.RemoteEndPoint}: {messageTxt}");
//}
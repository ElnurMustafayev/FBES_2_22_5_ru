using System.ComponentModel.DataAnnotations;

namespace FilesApp {
    internal class Program {
        static void Main() {
            if(true) {
                Stream stream = new FileStream("myfile.bin", mode: FileMode.OpenOrCreate, access: FileAccess.ReadWrite);

                // read buffer
                //byte[] buffer = new byte[1024];

                //int size = stream.Read(buffer, 0, buffer.Length);

                //for (int i = 0; i < size; i++) {
                //    Console.WriteLine($"{i}: {buffer[i]}");
                //}



                // write buffer
                //byte[] buffer = {
                //    65, 66, 67, 68, 69
                //};

                //stream.Write(buffer, 0, buffer.Length);
                //stream.Flush();



                //stream.WriteByte(65);
                //stream.Flush();
            }


            if (false) {
                Stream stream = new FileStream("test.txt", mode: FileMode.Truncate);

                // write byte
                //for (byte i = 48; i <= 57; i++) {
                //    stream.WriteByte(i);
                //}
                //stream.Flush();



                // read byte
                //while(true) {
                //    int b = stream.ReadByte();

                //    if (b == -1)
                //        break;

                //    Console.WriteLine(b);
                //}


                //stream.Position = 25;
                //stream.WriteByte(65);

                //stream.Flush();
            }
        }
    }
}
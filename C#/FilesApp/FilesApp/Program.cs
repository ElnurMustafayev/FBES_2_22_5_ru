using System.Text;

namespace FilesApp {
    public class MyClass : IDisposable {
        public void Dispose() {
            Console.WriteLine($"{nameof(MyClass)} was disposed");
        }
    }

    class Product {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public override string ToString() => $"{Name} {Price} $";
    }


    public class Program {
        static void WriteByteInFile(string path, byte b, int position = 0) {
            using (var stream = new FileStream(path, FileMode.OpenOrCreate)) {
                stream.Position = position;
                stream.WriteByte(b);
                stream.Flush();
            }

            //try {
            //    stream.Position = position;
            //    stream.WriteByte(b);
            //    stream.Flush();
            //}
            //catch (Exception ex) {
            //    Console.WriteLine(ex.Message);
            //}
            //finally {
            //    stream.Close();
            //}
        }

        static void Main() {
            // enter word: _ => write words.txt
            // if "history" => show words

            if(false) {
                const string filePath = "history.txt";

                while(true) {
                    Console.Clear();
                    var text = Console.ReadLine();

                    if (string.IsNullOrEmpty(text))
                        continue;

                    else if (text.ToLower() == "history") {
                        string[] lines = File.ReadAllLines(filePath);

                        for (int i = 0; i < lines.Length; i++) {
                            Console.WriteLine($"{i + 1}. {lines[i]}");
                        }
                        Console.ReadKey();
                    }

                    else {
                        File.AppendAllText(filePath, $"{text}\n");
                    }
                }
            }


            if (false) {
                //string text = File.ReadAllText("text.txt");
                //Console.WriteLine(text);

                string[] lines = File.ReadAllLines("text.txt");

                for (int i = 0; i < lines.Length; i++) {
                    Console.WriteLine($"{i}. {lines[i]}");
                }
            }

            if (false) {
                File.WriteAllText("text.txt", "Hello World!");
                File.WriteAllLines("text.txt", new string[] {
                    "One",
                    "Two",
                    "Three",
                });
            }



            if(false) {
                using FileStream stream = new FileStream("text.txt", mode: FileMode.Open, access: FileAccess.ReadWrite);
                using StreamReader reader = new StreamReader(stream);

                while(reader.EndOfStream == false) {
                    var text = reader.ReadLine();
                    Console.WriteLine(text);
                }
            }

            if(false) {
                Stream stream = new FileStream("text.txt", mode: FileMode.Append, access: FileAccess.Write);
                StreamWriter writer = new StreamWriter(stream);

                writer.WriteLine(new Product() { Name = "Apple", Price = 3 });
                writer.WriteLine(new Product() { Name = "Phone", Price = 2200 });
                writer.WriteLine(new Product() { Name = "Tv", Price = 700 });
                writer.WriteLine(new Product() { Name = "Car", Price = 30000 });
                writer.Flush();
            }

            if(false) {
                Stream stream = new FileStream("text.txt", mode: FileMode.OpenOrCreate, access: FileAccess.ReadWrite);
                
                // write string
                string message = "Hello World!";
                byte[] messageBytes = Encoding.ASCII.GetBytes(message);

                stream.Write(messageBytes, 0, messageBytes.Length);
                stream.Flush();

                // read string
                byte[] buffer = new byte[128];
                StringBuilder stringBuilder = new StringBuilder(capacity: buffer.Length);

                do {
                    int size = stream.Read(buffer, 0, buffer.Length);

                    var text = Encoding.ASCII.GetString(buffer, 0, size);

                    stringBuilder.Append(text);
                } while (stream.Position != stream.Length);

                Console.Write(stringBuilder);
            }






            if(false) {
                using var stream = new MyClass();

                Console.WriteLine("One");
                int num = 0;
                Console.WriteLine(12 / num);
                Console.WriteLine("Two");
                Console.WriteLine("Three");
            }

            if(false) {
                Console.WriteLine("four");
            }



            if(false) {
                try {
                    WriteByteInFile("test.txt", 67, -3);
                }
                catch(Exception ex) {
                    Console.WriteLine(ex.Message);
                }
            }




            if(false) {
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
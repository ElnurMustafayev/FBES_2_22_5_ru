using System.Runtime.CompilerServices;
using System.Text.Json;

namespace JsonApp {
    public class Program {

        static T GetJsonObjectFromFile<T>(string path) {
            var json = File.ReadAllText(path);

            return JsonSerializer.Deserialize<T>(json);
        }

        static void Main() {

            if(true) {
                //List<User> users = new List<User>() { 
                //    new User(),
                //    new User(),
                //    new User(),
                //};

                //var json = JsonSerializer.Serialize(users);

                //Console.WriteLine(json);

                var json = File.ReadAllText("data.json");
                Console.WriteLine(json);

                var users = JsonSerializer.Deserialize<IEnumerable<User>>(json);

                foreach (var user in users) {
                    Console.WriteLine(user.FirstName);
                }
            }




            if (false) {
                Teacher teacher = GetJsonObjectFromFile<Teacher>("Teacher.json");
                Student student = GetJsonObjectFromFile<Student>("Student.json");

                while(true) {
                    Console.Clear();
                    Console.WriteLine(@$"Hi, {teacher.FullName}

Press 1 to add mark to {student.Name}
Press 2 to show {student.Name}'s marks" + "\n\n\n");

                    var inputKey = Console.ReadKey(true).Key;

                    if (inputKey == ConsoleKey.D1 || inputKey == ConsoleKey.NumPad1) {
                        Console.Write("Input new mark: ");
                        if(int.TryParse(Console.ReadLine(), out int newMark)) {
                            student.Marks.Add(newMark);

                            var json = JsonSerializer.Serialize(student);
                            File.WriteAllText("Student.json", json);
                        }
                    }
                    else if(inputKey == ConsoleKey.D2 || inputKey == ConsoleKey.NumPad2) {
                        if(student.Marks == null || student.Marks.Count == 0) {
                            Console.WriteLine("No marks...");
                        }
                        else {
                            foreach (var mark in student.Marks) {
                                Console.WriteLine(mark);
                            }
                        }
                        Console.ReadKey();
                    }
                    else {
                        break;
                    }
                }
            }



            if(false) {
                var car = new Car("BMW M5", 320);
                car.Driver = new User() {
                    FirstName = "Elnur",
                    LastName = "Mustafayev"
                };

                car.Passengers = new List<User>() {
                    new User(),
                    new User(),
                    new User(),
                };

                string json = JsonSerializer.Serialize(car);
                File.WriteAllText("data.json", json);


                //string json = File.ReadAllText("data.json");
                //Car car = JsonSerializer.Deserialize<Car>(json);

                //foreach (var item in car.Test) {
                //    Console.WriteLine(item);
                //}
            }





            if(false) {
                // JsonSerializer

                // create class with:
                // int, string, double, bool, datetime

                // filename: "<type>.json"
                // json save
                // json load
            }


            if (false) {
                // Load as json
                //string json = File.ReadAllText("user.json");
                //User user = JsonSerializer.Deserialize<User>(json);

                User user = User.LoadJson("user.json");

                Console.WriteLine(user.FirstName);
                Console.WriteLine(user.LastName);
                Console.WriteLine(user.CreationDateUtc);
                Console.WriteLine(user.Age);
                Console.WriteLine(user.IsMarried);
            }


            if(false) {
                // Save as json
                /*
                {
                  "FirstName": "Bob",
                  "LastName": "Marley",
                  "Age": 43,
                  "IsMarried": true
                }
                 */
                User user = new User() {
                    FirstName = "Bob",
                    LastName = "Marley",
                    Age = 16,
                    IsMarried = false
                };

                user.SaveJson("user.json");

                //string json = JsonSerializer.Serialize(user);
                //Console.WriteLine(json);
            }




            if(false) {
                // Load as text
                User user = new User();
                user.LoadText("user.txt");
            }


            if(false) {
                // Save as text
                User user = new User() {
                    FirstName = "Bob",
                    LastName = "Marley",
                    Age = 43
                };

                user.SaveText("user.txt");
            }
        }
    }
}
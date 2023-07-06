using System.Text.Json;
using System.Xml.Linq;

namespace LinqApp;

public static class MyLinq {
    public static void TestMethod<T>(this T obj) {
        Console.WriteLine(typeof(T).Name);
    }

    public static void TestMethod<T>(this IEnumerable<T> collection) {
        foreach (var item in collection) {
            Console.WriteLine($"{item?.GetType().Name} - {typeof(T).Name}");
        }
    }
}

public class Person {
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public DateTime? BirthDate { get; set; }

    public Person(string? name, string? surname, DateTime? birthDate) {
        this.Name = name;
        this.Surname = surname;
        this.BirthDate = birthDate;
    }
}



public enum Gender {
    Male,
    Female,
};


public class User {
    public int id { get; set; }
    public string name { get; set; }
    public string surname { get; set; }
    public Gender gender { get; set; }
    public DateTime birthdate { get; set; }

    public override string ToString() =>  $"#{id}: {name} {surname}. {gender} {birthdate.ToShortDateString()}";
}



public class Program {
    public static void Main() {

        if(true) {
            //IEnumerable<int> nums = new int[] { 1, 2, 6, 7, 9, 3, 4, 5 };

            //var result = nums.Max();
            //var result = nums.Min();
            //var result = nums.Average();
            //var result = nums.Sum();
            //Console.WriteLine(result);


            //IEnumerable<string> names = new List<string> {
            //    "Elnur", "Emil", "a"
            //};

            //var result = names.Max();
            //var result = names.Max();
            //var result = names.Sum(name => 5);
            //var result = names.Average(name => name.Length);
            //Console.WriteLine(result);



            var json = File.ReadAllText("assets\\People.json");
            IEnumerable<User> users = JsonSerializer.Deserialize<IEnumerable<User>>(json);

            //var maxBirthDate = users.Min(user => user.birthdate);
            //Console.WriteLine(maxBirthDate);

            var minBirthDate = users.Min(user => user.birthdate);
            var oldUser = users.First(user => user.birthdate == minBirthDate);

            Console.WriteLine(oldUser);

        }

        if (false) {
            //var json = File.ReadAllText("assets\\People.json");
            //IEnumerable<User> users = JsonSerializer.Deserialize<IEnumerable<User>>(json);

            //var result = users.Append(new User());

            //Console.WriteLine(result.Count());



            IEnumerable<string> names = new List<string> {
                "Nijat", "Raul", "Jafar"
            };

            names = names.Append("Elnur")
                .Append("Qasim")
                .Append("Deniz")
                .Append("Ayxan");

            Console.WriteLine(names.Count());

            foreach (var name in names) {
                Console.WriteLine(name);
            }
        }


        if(false) {
            var json = File.ReadAllText("assets\\People.json");
            IEnumerable<User> users = JsonSerializer.Deserialize<IEnumerable<User>>(json);

            //var allMale = users.All(user => user.gender == Gender.Male);
            //var normaleName = users.All(user => string.IsNullOrWhiteSpace(user.name) == false);
            //Console.WriteLine(normaleName);

            //var containsBob = users.Any(user => user.name.ToLower().Contains("bob"));
            //var containsElnur = users.Any(user => user.name == "Elnur");

            //Console.WriteLine(containsBob);
            //Console.WriteLine(containsElnur);
        }



        if(false) {
            //var str = "".ToLower().ToLower().ToLower().Trim().Substring(1)[1..2][2..].Count().ToString();

            var result = new int[] { 1, 2, 3, 4, 5, 6, 7, 9 }
                .Where(num => num % 2 == 0)
                .Where(num => num >= 4)
                .First();

            Console.WriteLine(result);
        }


        if(false) {
            var json = File.ReadAllText("assets\\People.json");
            List<User> users = JsonSerializer.Deserialize<List<User>>(json);


            IEnumerable<User> result = users.Where(user => {
                bool isAdults = DateTime.Now.Year - user.birthdate.Year >= 18;
                bool isLongName = user.name.Length > 10;

                return isAdults && isLongName;
            });

            foreach (var item in result) {
                Console.WriteLine(item);
            }

            //var adultsCount = users.Count(user => DateTime.Now.Year - user.birthdate.Year >= 18);
            //Console.WriteLine($"Adults: {adultsCount}");
        }


        if (false) {
            var json = File.ReadAllText("assets\\People.json");
            List<User> users = JsonSerializer.Deserialize<List<User>>(json);

            Console.WriteLine(users.Count());
            Console.WriteLine(users.Count);
        }

        if (false) {
            IEnumerable<Person> people = new List<Person>() {
                new Person("Bob", "Marley", new DateTime(1965, 7, 7)),
                new Person("Ann", "Brown", null),
                new Person("John", "Black", new DateTime(2009, 3, 15)),
            };

            Func<Person, bool> isAdult = person => {
                //return DateTime.Now.Year - person.BirthDate?.Year >= 18;

                if (person.BirthDate.HasValue == false)
                    return false;
                return DateTime.Now.Year - person.BirthDate.Value.Year >= 18;
            };

            //int result = people.Count(isAdult);
            //Console.WriteLine(result);

            Person result = people.First(isAdult);
            Console.WriteLine(result.Name + " " + result.Surname);
        }

        if (false) {
            // создать массив arr типа данных string[]
            // вернуть 1-ый элемент, который хранит внутри
            // себя минимум 3 указанных символа

            // при условии, что указанный символ = "а"
            // "aaa" => true
            // "aDdfsasdf" => false
            // "aa123123dfdfa" => true
            // "aa23aadfa" => true

            string[] arr = new string[] {
                "test3141aa", "aabncaa12", "vxcavxcv"
            };

            var result = arr.First(str => str.Count(symbol => symbol == 'a') >= 3);
            Console.WriteLine(result);


            //var result = arr.First(str => {
            //    if (str.Count(symbol => symbol == 'a') >= 3) {
            //        Console.WriteLine("Found");
            //        return true;
            //    }
            //    else {
            //        Console.WriteLine("Not found");
            //        return false;
            //    }
            //});

            //var symbolsCount = str.Count(symbol => symbol == 'a');
        }


        if (false) {
            IEnumerable<int> collection = new List<int> {
                1, 2, 3, 4, 5, 6, 7
            };

            var result = collection.First(item => item % 2 == 0);
            result = collection.FirstOrDefault(item => item > 100, defaultValue: 150);
            Console.WriteLine(result);

            //var result = collection.First();
            //Console.WriteLine(result);

            //var result = collection.FirstOrDefault();
            //Console.WriteLine(result);
        }


        if (false) {
            IEnumerable<string> collection = new string[] {
                "one", "two", "three"
            };

            var result = collection.Count(obj => obj.Length > 3);
            Console.WriteLine(result);

            //Console.WriteLine(collection.Count());
        }

        if (false) {
            //IEnumerable<int> nums = new int[] {
            //    1,2,3
            //};

            //nums.TestMethod();



            //Program program = new Program();
            //program.TestMethod();

            //int num = 0;
            //num.TestMethod();
        }
    }
}
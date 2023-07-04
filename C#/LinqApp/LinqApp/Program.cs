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


public class Program {
    public static void Main() {
        if(true) {
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


        if(false) {
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
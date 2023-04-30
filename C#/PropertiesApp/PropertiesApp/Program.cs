namespace PropertiesApp;

public class Program {
    //public static Car GetCar() => new Car() {
    //    count = 123,
    //    Year = 123,
    //    Model = "123",
    //};

    private static void Main() {
        try {
            Person person = new Person() {
                Name = "Bob",
                Surname = "Marley",
                Age = 20,
                HasDriverLicense = true,
            };

            Car car = new Car() {
                Number = "99AA777",
                Driver = person,
            };
        }
        catch(Exception ex) {
            Console.WriteLine($"Error: {ex.ToString()}");
        }




        // Car
        //      Driver: Person (Ok Name, Ok Surname, HasDriverLicense == true, Age >= 18)
        //      Number: string ("99AA777")



        //Car car = new Car() {
        //    count = 123,
        //    WeelsCount = 8,
        //    Model = "123",
        //};

        //Console.WriteLine(car.Model);





        /*
            Car car = new Car();
            car.Year = 100;
            Console.WriteLine(car.Year);
        */



        //Product product = new Product();
        //product.Status = ProductStatus.bestseller;
        //product.Status = ProductStatus.soldout;
        //Console.WriteLine(product.Status);



        //User user = new User("nickname", "login");
        //user.Nickname = "Bob777";
        //user.Login = "Bob777";
        //Console.WriteLine(user.Login);



        //Person person = new Person();

        //person.Age = 123;
        //Console.WriteLine(person.Age);
    }
}
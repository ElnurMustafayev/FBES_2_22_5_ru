using ClassesAndStructs;


//Person person1 = new Person();

//person1.Name = "Bob";
//person1.Surname = "Marley";
//person1.Age = 50;

//Person person2 = person1;

//person2.Age = 20;
//person1.Name = "Test";

//Console.WriteLine("Person 1: ");
//person1.Show();
//Console.WriteLine("Person 2: ");
//person2.Show();



//Car car1 = new Car();
//car1.Model = "Lada";
//car1.MaxSpeed = 300;

//Car car2 = car1;

//car1.Model = "Tesla";
//car1.MaxSpeed = 80;

//Console.WriteLine(car1.GetInfo());
//Console.WriteLine(car2.GetInfo());



//Person person = new Person();
//person.Name = "Eldaniz";
//person.Surname = "Yolchuyev";
//person.Age = 19;

//Car car1 = new Car();
//car1.Model = "Porsche";
//car1.MaxSpeed = 280;
//car1.Driver = person;



//Car car2 = car1;
//car2.Model = "Tesla";
//car2.Driver = new Person();
//car2.Driver.Age = 35;
//car2.Driver.Name = "Test";

//car1.Show();
//Console.WriteLine();
//car2.Show();



//Person person = new Person();



Person[] people = new Person[3] {
    new Person("One", "One", 1),
    new Person("Two", "Two", 2),
    new Person("Three", "Three", 2),
};

for (int i = 0; i < people.Length; i++) {
    Person p = people[i];
    p.Show();
}
namespace ClassesAndStructs;

class Person {
    public string Name;
    public string Surname;
    public int Age;

    public Person() {

    }

    public Person(string name, string surname, int age) {
        this.Name = name;
        this.Surname = surname;
        this.Age = age;
    }

    public void Show() {
        Console.WriteLine(this.Name);
        Console.WriteLine(this.Surname);
        Console.WriteLine(this.Age);
    }
}
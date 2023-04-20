namespace TryCatchFinalyApp;

public class Person {
    public string Name;
    public string Surname;
    public int Age;

    public Person(string name, string surname, int age) {
        if(string.IsNullOrWhiteSpace(name)) {
            //Console.WriteLine($"'{nameof(name)}' can not be empty!");
            throw new ArgumentNullException(paramName: nameof(name), message: $"'{nameof(name)}' can not be empty!");
        }
        if (string.IsNullOrWhiteSpace(surname)) {
            //Console.WriteLine($"'{nameof(surname)}' can not be empty!");
            throw new ArgumentNullException(paramName: nameof(surname), message: $"'{nameof(surname)}' can not be empty!");
        }
        if(age <= 0 || age >= 140) {
            //Console.WriteLine($"incorrect '{nameof(age)}' value!");
            throw new ArgumentException(paramName: nameof(age), message: $"incorrect '{nameof(age)}' value!");
        }

        this.Name = name;
        this.Surname = surname;
        this.Age = age;
    }
}

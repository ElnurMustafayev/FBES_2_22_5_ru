namespace IteratorApp;

public class Person {
    public string Fullname { get; set; }

    public Person(string fullname) {
        Fullname = fullname;
    }

    public override string ToString() => this.Fullname;
}
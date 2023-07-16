namespace AbstractFactoryApp.Animals.Base;

public abstract class Animal {
    public string? Name { get; set; }

    public abstract void Say();

    public override string ToString() => $"Name: {this.Name}";
}
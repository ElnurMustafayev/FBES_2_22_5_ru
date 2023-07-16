namespace AbstractFactoryApp.Animals;

using AbstractFactoryApp.Animals.Base;

public class Cat : Animal {
    public bool IsPurebred { get; set; } = true;

    public override void Say() => Console.WriteLine("meow");
    public override string ToString() => $"{base.ToString()}\nIs Purebred?: {IsPurebred}";
}
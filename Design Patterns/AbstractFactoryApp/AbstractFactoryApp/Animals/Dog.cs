namespace AbstractFactoryApp.Animals;

using AbstractFactoryApp.Animals.Base;

public class Dog : Animal {
    public bool IsFighting { get; set; } = false;

    public override void Say() => Console.WriteLine("huf");
    public override string ToString() => $"{base.ToString()}\nIs Fighting?: {IsFighting}";
}
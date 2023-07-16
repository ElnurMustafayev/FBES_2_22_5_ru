namespace AbstractFactoryApp.Animals;

using AbstractFactoryApp.Animals.Base;
using System.Drawing;

public class Horse : Animal {
    public Color Color { get; set; } = Color.Black;

    public override void Say() => Console.WriteLine("igogo");
    public override string ToString() => $"{base.ToString()}\nColor: {this.Color.Name}";
}
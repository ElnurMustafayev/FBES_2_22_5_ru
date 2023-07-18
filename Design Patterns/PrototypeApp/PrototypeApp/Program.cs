using PrototypeApp.Models;

namespace PrototypeApp;

public class Program {
    static void Main() {
        Button firstButton = new Button("first");
        Console.WriteLine(firstButton);

        //Button button2 = new Button("second");
        Button button2 = firstButton.Clone();
        button2.Content = "second";
        Console.WriteLine(button2);

        //Button button3 = new Button("third");
        Button button3 = firstButton.Clone();
        button3.Content = "third";
        Console.WriteLine(button3);


        //Button button1 = new Button("Click me! 1");
        //Button button2 = new Button("Click me! 2");
        //Button button3 = new Button("Click me! 3");
    }
}
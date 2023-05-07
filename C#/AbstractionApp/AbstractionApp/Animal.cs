namespace AbstractionApp;

public abstract class Animal {
    public string Name;

    //public virtual void Say() {
    //    Console.WriteLine("animal");
    //}

    public abstract bool CanFly { get; }

    public abstract void Say();

    //override public string ToString() => "This is an aminal!";
}

public class Cat : Animal {
    public override bool CanFly => false;

    public override void Say() {
        Console.WriteLine("meow");
    }
}

public class Lion : Cat {
    public override void Say() {
        Console.WriteLine("roah");
    }
}
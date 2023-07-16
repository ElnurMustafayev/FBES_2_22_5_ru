namespace AbstractFactoryApp.Animals;

public class ZombieCat : Cat {
    public override void Say() {
        base.Say();
        Console.WriteLine("brainsssss...");
    }
}
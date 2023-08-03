namespace StateApp.States.Human;

using StateApp.States.Human.Base;
using StateApp;

public class HumanDrunkState : IHumanState {
    private readonly Human human;

    public HumanDrunkState(Human human) {
        this.human = human;
    }

    public void Jump() {
        Console.WriteLine($"... fallen ...");
    }

    public void Walk() {
        Console.WriteLine($"{this.human.FullName} is wal... fallen...");
    }
}
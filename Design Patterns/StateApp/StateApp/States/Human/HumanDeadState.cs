namespace StateApp.States.Human;

using StateApp.States.Human.Base;
using StateApp;

public class HumanDeadState : IHumanState {
    private readonly Human human;

    public HumanDeadState(Human human) {
        this.human = human;
    }

    public void Jump() {
        Console.WriteLine($"{this.human.FullName} is dead.");
    }

    public void Walk() {
        Console.WriteLine($"{this.human.FullName} is dead.");
    }
}
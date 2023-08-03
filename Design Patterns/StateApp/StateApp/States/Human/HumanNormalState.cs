namespace StateApp.States.Human;

using StateApp.States.Human.Base;
using StateApp;

public class HumanNormalState : IHumanState {
    private readonly Human human;

    public HumanNormalState(Human human) {
        this.human = human;
    }

    public void Jump() {
        Console.WriteLine($"{this.human.FullName} is jumping...");
    }

    public void Walk() {
        Console.WriteLine($"{this.human.FullName} is walking...");
    }
}
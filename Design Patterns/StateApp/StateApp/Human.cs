namespace StateApp;

using StateApp.States.Human;
using StateApp.States.Human.Base;

public class Human {
    public string Name { get; set; }
    public string Surname { get; set; }
    public string FullName => $"{Name} {Surname}";
    public IHumanState State { get; set; }

    //public HumanStates State { get; set; }

    public Human(string name, string surname) {
        Name = name;
        Surname = surname;
        //State = HumanStates.normal;
        State = new HumanNormalState(this);
    }

    public void Walk() {
        this.State.Walk();
        //switch (State) {
        //    case HumanStates.normal:
        //        Console.WriteLine($"{FullName} is walking...");
        //        break;
        //    case HumanStates.dead:
        //        Console.WriteLine($"{FullName} is dead.");
        //        break;
        //    case HumanStates.drunk:
        //        Console.WriteLine($"{FullName} is wal... fallen...");
        //        break;
        //    default:
        //        break;
        //}
    }

    public void Jump() {
        this.State.Jump();
        //switch (State) {
        //    case HumanStates.normal:
        //        Console.WriteLine($"{FullName} is jumping...");
        //        break;
        //    case HumanStates.dead:
        //        Console.WriteLine($"{FullName} is dead.");
        //        break;
        //    case HumanStates.drunk:
        //        Console.WriteLine($"... fallen ...");
        //        break;
        //    default:
        //        break;
        //}
    }
}
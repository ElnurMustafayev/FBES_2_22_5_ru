namespace BuilderApp.Builders;

using BuilderApp.Builders.Base;
using BuilderApp.Models;

public class HouseBuilderWithLogs : IHouseBuilder<House> {
    private House house = new House();
    private readonly Action<string> whatToDoWithLog;

    public HouseBuilderWithLogs(Action<string> whatToDoWithLog) {
        this.whatToDoWithLog = whatToDoWithLog;
    }

    public void BuildWindows(int windowsCount) {
        house.WindowsCount = windowsCount;
        //Console.WriteLine($"Build {windowsCount} windows for house {house.GetHashCode()}");
        whatToDoWithLog.Invoke($"Build {windowsCount} windows for house {house.GetHashCode()}");
    }

    public void BuildDoors(int doorsCount) {
        house.DoorsCount = doorsCount;
        //Console.WriteLine($"Build {doorsCount} doors for house {house.GetHashCode()}");
        whatToDoWithLog.Invoke($"Build {doorsCount} doors for house {house.GetHashCode()}");
    }

    public void BuildRooms(int roomsCount) {
        house.RoomsCount = roomsCount;
        //Console.WriteLine($"Build {roomsCount} rooms for house {house.GetHashCode()}");
        whatToDoWithLog.Invoke($"Build {roomsCount} rooms for house {house.GetHashCode()}");
    }

    public void BuildGarage() {
        house.HasGarage = true;
        //Console.WriteLine($"Build garage for house {house.GetHashCode()}");
        whatToDoWithLog.Invoke($"Build garage for house {house.GetHashCode()}");
    }

    public void BuildPool() {
        house.HasPool = true;
        //Console.WriteLine($"Build pool for house {house.GetHashCode()}");
        whatToDoWithLog.Invoke($"Build pool for house {house.GetHashCode()}");
    }

    public void PlantDecorations(params Decoration[] decorations) {
        if (house.Decorations == null) {
            house.Decorations = new List<Decoration>();
        }

        foreach (var decoration in decorations) {
            house.Decorations = house.Decorations.Append(decoration);
        }

        //Console.WriteLine($"Plant decors for house {house.GetHashCode()}");
        whatToDoWithLog.Invoke($"Plant decors for house {house.GetHashCode()}");
    }

    public House GetResult() {
        House result = house;
        this.Reset();

        return result;
    }

    public void Reset() {
        this.house = new House();
    }
}
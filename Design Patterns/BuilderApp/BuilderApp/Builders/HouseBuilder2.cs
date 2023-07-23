namespace BuilderApp.Builders;

using BuilderApp.Models;

public class HouseBuilder2 {
    private House house;

    public HouseBuilder2() {
        this.house = new House();
    }

    public HouseBuilder2 BuildWindows(int windowsCount) {
        house.WindowsCount += windowsCount;

        return this;
    }

    public HouseBuilder2 BuildDoors(int doorsCount) {
        house.DoorsCount += doorsCount;

        return this;
    }

    public HouseBuilder2 BuildRooms(int roomsCount) {
        house.RoomsCount += roomsCount;

        return this;
    }

    public HouseBuilder2 BuildGarage() {
        house.HasGarage = true;

        return this;
    }

    public HouseBuilder2 BuildPool() {
        house.HasPool = true;

        return this;
    }

    public HouseBuilder2 PlantDecorations(params Decoration[] decorations) {
        if (house.Decorations == null) {
            //house.Decorations = new List<Decoration>();
            house.Decorations = Enumerable.Empty<Decoration>();
        }

        foreach (var decoration in decorations) {
            house.Decorations = house.Decorations.Append(decoration);
        }

        return this;
    }

    public House GetResult() {
        if (this.house.DoorsCount == 0)
            throw new ArgumentException("Doors count can not be 0");

        bool hasDecor = house.Decorations != null && house.Decorations.Any();
        if (this.house.HasPool && !hasDecor)
            throw new ArgumentException("If house has pool it must have decor!");

        House result = house;
        this.house = new House();

        return result;
    }
}
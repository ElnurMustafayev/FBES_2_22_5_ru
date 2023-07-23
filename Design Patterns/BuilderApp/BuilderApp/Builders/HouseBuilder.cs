namespace BuilderApp.Builders;

using BuilderApp.Builders.Base;
using BuilderApp.Models;

public class HouseBuilder : IHouseBuilder<House> {
    private House house;

	public HouseBuilder() {
		this.house = new House();
    }

    public void BuildWindows(int windowsCount) {
        house.WindowsCount += windowsCount;
    }

    public void BuildDoors(int doorsCount) {
        house.DoorsCount += doorsCount;
    }

    public void BuildRooms(int roomsCount) {
        house.RoomsCount += roomsCount;
    }

    public void BuildGarage() {
        house.HasGarage = true;
    }

    public void BuildPool() {
        house.HasPool = true;
    }

    public void PlantDecorations(params Decoration[] decorations) {
        if(house.Decorations == null) {
            //house.Decorations = new List<Decoration>();
            house.Decorations = Enumerable.Empty<Decoration>();
        }

        foreach (var decoration in decorations) {
            house.Decorations = house.Decorations.Append(decoration);
        }
    }

    public House GetResult() {
        if (this.house.DoorsCount == 0)
            throw new ArgumentException("Doors count can not be 0");

        bool hasDecor = house.Decorations != null && house.Decorations.Any();
        if (this.house.HasPool && !hasDecor)
            throw new ArgumentException("If house has pool it must have decor!");

        House result = house;
        this.Reset();

        return result;
    }

    public void Reset() {
        this.house = new House();
    }
}
namespace BuilderApp.Directors;

using BuilderApp.Builders.Base;
using BuilderApp.Directors.Base;
using BuilderApp.Models;

public class RichHouseDirector : IHouseDirector<House> {
    private IHouseBuilder<House> houseBuilder;

    public RichHouseDirector(IHouseBuilder<House> houseBuilder) {
        this.houseBuilder = houseBuilder;
    }

    public void ChangeBuilder(IHouseBuilder<House> houseBuilder) {
        this.houseBuilder = houseBuilder;
    }

    public House Make() {
        this.houseBuilder.BuildWindows(10);
        this.houseBuilder.BuildDoors(4);
        this.houseBuilder.BuildRooms(4);
        this.houseBuilder.BuildPool();
        this.houseBuilder.BuildGarage();
        this.houseBuilder.PlantDecorations(new Decoration("Statue"));

        return this.houseBuilder.GetResult();
    }
}
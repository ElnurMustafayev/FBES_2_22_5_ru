namespace BuilderApp.Directors;

using BuilderApp.Builders.Base;
using BuilderApp.Directors.Base;
using BuilderApp.Models;

public class SimpleHouseDirector : IHouseDirector<House> {
    private IHouseBuilder<House> houseBuilder;

    public SimpleHouseDirector(IHouseBuilder<House> houseBuilder) {
        this.houseBuilder = houseBuilder;
    }

    public void ChangeBuilder(IHouseBuilder<House> houseBuilder) {
        this.houseBuilder = houseBuilder;
    }

    public House Make() {
        this.houseBuilder.BuildWindows(2);
        this.houseBuilder.BuildDoors(1);
        this.houseBuilder.BuildRooms(1);
        this.houseBuilder.PlantDecorations(new Decoration("Tree"));

        return this.houseBuilder.GetResult();
    }
}

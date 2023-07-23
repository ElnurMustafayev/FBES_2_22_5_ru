namespace BuilderApp.Builders.Base;

using BuilderApp.Models;

public interface IHouseBuilder<THouse> : IBuilder<THouse> where THouse : House {
    public void BuildWindows(int windowsCount);
    public void BuildDoors(int doorsCount);
    public void BuildRooms(int roomsCount);
    public void BuildGarage();
    public void BuildPool();
    public void PlantDecorations(params Decoration[] decorations);
}
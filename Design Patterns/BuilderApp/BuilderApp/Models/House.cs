namespace BuilderApp.Models;

public class House {
    public int WindowsCount { get; set; }
    public int DoorsCount { get; set; }
    public int RoomsCount { get; set; }
    public bool HasPool { get; set; }
    public bool HasGarage { get; set; }
    public IEnumerable<Decoration>? Decorations { get; set; }

    //public House(int windowsCount, int doorsCount, int roomsCount, bool hasPool, bool hasGarage, IEnumerable<Decoration>? decorations) {
    //    this.WindowsCount = windowsCount;
    //    this.DoorsCount = doorsCount;
    //    this.RoomsCount = roomsCount;
    //    this.HasPool = hasPool;
    //    this.HasGarage = hasGarage;
    //    this.Decorations = decorations;
    //}

    public House() {

    }

    public override string ToString() {
        return @$"House info: 
Windows count: {WindowsCount}
Doors count: {DoorsCount}
Rooms count: {RoomsCount}
Has pool?: {HasPool}
Has garage?: {HasGarage}
Decorations count: {Decorations?.Count() ?? 0}";
    }
}
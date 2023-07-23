using BuilderApp.Builders;
using BuilderApp.Builders.Base;
using BuilderApp.Directors;
using BuilderApp.Directors.Base;
using BuilderApp.Models;

namespace BuilderApp;

public class Program {
    static void Main() {
        //var house = new House(2, 1, 1, false, false, null);

        //var house = new House() {
        //    WindowsCount = 2,
        //    DoorsCount = 1,
        //    RoomsCount = 1,
        //};





        //HouseBuilder houseBuilder = new HouseBuilder();

        //houseBuilder.BuildWindows(10);
        //houseBuilder.BuildDoors(4);
        //houseBuilder.BuildRooms(4);
        //houseBuilder.BuildPool();
        //houseBuilder.BuildGarage();
        //houseBuilder.PlantDecorations(new Decoration("Statue"));

        //var richHouse = houseBuilder.GetResult();

        //Console.WriteLine($"$$$RICH$$$ {richHouse}");



        //houseBuilder.BuildWindows(2);
        //houseBuilder.BuildDoors(1);
        //houseBuilder.BuildRooms(1);
        //houseBuilder.PlantDecorations(new Decoration("Tree"));

        //var simpleHouse = houseBuilder.GetResult();

        //Console.WriteLine($"Simple {simpleHouse}");




        //HouseBuilder2 houseBuilder = new HouseBuilder2();

        //var result = houseBuilder
        //    .BuildWindows(2)
        //    .BuildDoors(1)
        //    .BuildRooms(1)
        //    .PlantDecorations(new Decoration("Tree"))
        //    .GetResult();

        //Console.WriteLine(result);


        //IHouseBuilder<House> houseBuilder = new HouseBuilder();
        //houseBuilder.BuildWindows(2);
        //houseBuilder.BuildDoors(1);
        //houseBuilder.BuildRooms(1);
        //houseBuilder.PlantDecorations(new Decoration("Tree"));
        //var house = houseBuilder.GetResult();
        //Console.WriteLine(house);






        IHouseBuilder<House> houseBuilder = new HouseBuilderWithLogs((logStr) => {
            //Console.WriteLine($"Log ({DateTime.Now.ToShortTimeString()}): {logStr}");

            logStr = $"Log ({DateTime.Now.ToShortTimeString()}): {logStr}\n";
            File.AppendAllText("log.txt", logStr);
        });

        IHouseDirector<House> houseDirector = new SimpleHouseDirector(houseBuilder);
        houseDirector = new RichHouseDirector(houseBuilder);
        var house = houseDirector.Make();

        Console.WriteLine(house);
    }
}
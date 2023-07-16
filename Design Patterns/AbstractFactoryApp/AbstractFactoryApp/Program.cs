namespace AbstractFactoryApp;

using AbstractFactoryApp.Animals;
using AbstractFactoryApp.Animals.Base;
using AbstractFactoryApp.Factories;
using AbstractFactoryApp.Factories.Base;
using AbstractFactoryApp.Services;

class Program {
    static void Main() {
        //AnimalService animalService = new AnimalService(new ZombieAnimalFactory());

        //var result = animalService.CreateCat("Rijik");
        //Console.WriteLine(result.GetType().Name);

        //Animal animal = AnimalService.GetAnimal();
        //Console.WriteLine(animal);
        //Console.WriteLine(animal.GetType().Name);










        //IAnimalFactory animalFactory = new ZombieAnimalFactory();

        //Cat cat = animalFactory.GetCat("Rijik");
        //Console.WriteLine(cat);
        //Console.WriteLine();

        //Dog dog = animalFactory.GetDog("Barsik");
        //Console.WriteLine(dog);
        //Console.WriteLine();

        //Horse horse = animalFactory.GetHorse("Spirit");
        //Console.WriteLine(horse);
        //Console.WriteLine();






        //var animalService = new AnimalService();

        //while (true) {
        //    Console.WriteLine("Press 'Enter' to generate animal: ");

        //    if(Console.ReadKey().Key == ConsoleKey.Enter) {
        //        animalService.GetAnimal();
        //    }
        //    else {
        //        break;
        //    }
        //}





        //var dog = animalService.GetDog(name: "Barsik");
        //Console.WriteLine(dog);

        //Console.WriteLine();

        //var cat = animalService.GetCat(name: "Rijik");
        //Console.WriteLine(cat);

        //Console.WriteLine();

        //var horse = animalService.GetHorse(name: "Spirit");
        //Console.WriteLine(horse);
    }
}
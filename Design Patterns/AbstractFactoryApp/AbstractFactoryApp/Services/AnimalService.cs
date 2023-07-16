namespace AbstractFactoryApp.Services;

using AbstractFactoryApp.Animals;
using AbstractFactoryApp.Animals.Base;
using AbstractFactoryApp.Factories;
using AbstractFactoryApp.Factories.Base;

public class AnimalService {
    private IAnimalFactory animalFactory;

    public AnimalService(IAnimalFactory animalFactory) {
        this.animalFactory = animalFactory ?? new AnimalFactory();
    }

    public Cat CreateCat(string name) {
        if (string.IsNullOrWhiteSpace(name))
            return null;

        return this.animalFactory.GetCat(name);
    }

    public Dog CreateDog(string name) {
        if (string.IsNullOrWhiteSpace(name))
            return null;

        return this.animalFactory.GetDog(name);
    }

    public Horse CreateHorse(string name) {
        if (string.IsNullOrWhiteSpace(name))
            return null;

        return this.animalFactory.GetHorse(name);
    }

    public static Animal GetAnimal() {
        var random = new Random();

        IAnimalFactory animalFactory = random.Next(0, 2) == 0
            ? new AnimalFactory()
            : new ZombieAnimalFactory();

        switch (random.Next(0, 3)) {
            case 0:
                return animalFactory.GetCat();
            case 1:
                return animalFactory.GetDog();
            case 2:
                return animalFactory.GetHorse();
            default:
                throw new Exception("Something went wrong...");
        }
    }






    //public Cat GetCat(string? name = null) {
    //    var animal = new Cat();
    //    animal.Name = name;
    //    Console.WriteLine($"Animal '{animal.GetType().Name}' created");
    //    animal.Say();
    //    return animal;
    //}

    //public Dog GetDog(string? name = null) {
    //    var animal = new Dog();
    //    animal.Name = name;
    //    Console.WriteLine($"Animal '{animal.GetType().Name}' created");
    //    animal.Say();
    //    return animal;
    //}

    //public Horse GetHorse(string? name = null) {
    //    var animal = new Horse();
    //    animal.Name = name;
    //    Console.WriteLine($"Animal '{animal.GetType().Name}' created");
    //    animal.Say();
    //    return animal;
    //}

    //public ZombieCat GetZombieCat(string? name = null) {
    //    var zombieAnimal = new ZombieCat();
    //    zombieAnimal.Name = name;
    //    Console.WriteLine($"Zombie Animal '{zombieAnimal.GetType().Name}' created");
    //    zombieAnimal.Say();
    //    return zombieAnimal;
    //}

    //public ZombieDog GetZombieDog(string? name = null) {
    //    var zombieAnimal = new ZombieDog();
    //    zombieAnimal.Name = name;
    //    Console.WriteLine($"Zombie Animal '{zombieAnimal.GetType().Name}' created");
    //    zombieAnimal.Say();
    //    return zombieAnimal;
    //}

    //public ZombieHorse GetZombieHorse(string? name = null) {
    //    var zombieAnimal = new ZombieHorse();
    //    zombieAnimal.Name = name;
    //    Console.WriteLine($"Zombie Animal '{zombieAnimal.GetType().Name}' created");
    //    zombieAnimal.Say();
    //    return zombieAnimal;
    //}

    //public Animal GetAnimal() {
    //    var randIndex = Random.Shared.Next(0, 3);

    //    switch (randIndex) {
    //        case 0:
    //            return this.GetCat();
    //        case 1:
    //            return this.GetDog();
    //        case 2:
    //            return this.GetHorse();
    //        default:
    //            throw new Exception("Something went wrong...");
    //    }
    //}
}
namespace AbstractFactoryApp.Factories;

using AbstractFactoryApp.Animals;
using AbstractFactoryApp.Factories.Base;

public class ZombieAnimalFactory : IAnimalFactory {
    public Cat GetCat(string? name = null) {
        var animal = new ZombieCat();
        animal.Name = name;
        Console.WriteLine($"Zombie Animal '{animal.GetType().Name}' created by '{this.GetType().Name}'");
        animal.Say();
        return animal;
    }

    public Dog GetDog(string? name = null) {
        var animal = new ZombieDog();
        animal.Name = name;
        Console.WriteLine($"Zombie Animal '{animal.GetType().Name}' created by '{this.GetType().Name}'");
        animal.Say();
        return animal;
    }

    public Horse GetHorse(string? name = null) {
        var animal = new ZombieHorse();
        animal.Name = name;
        Console.WriteLine($"Zombie Animal '{animal.GetType().Name}' created by '{this.GetType().Name}'");
        animal.Say();
        return animal;
    }
}

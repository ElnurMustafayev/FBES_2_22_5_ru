namespace AbstractFactoryApp.Factories;

using AbstractFactoryApp.Animals;
using AbstractFactoryApp.Factories.Base;

public class AnimalFactory : IAnimalFactory {
    public Cat GetCat(string? name = null) {
        var animal = new Cat();
        animal.Name = name;
        Console.WriteLine($"Animal '{animal.GetType().Name}' created by '{this.GetType().Name}'");
        animal.Say();
        return animal;
    }

    public Dog GetDog(string? name = null) {
        var animal = new Dog();
        animal.Name = name;
        Console.WriteLine($"Animal '{animal.GetType().Name}' created by '{this.GetType().Name}'");
        animal.Say();
        return animal;
    }

    public Horse GetHorse(string? name = null) {
        var animal = new Horse();
        animal.Name = name;
        Console.WriteLine($"Animal '{animal.GetType().Name}' created by '{this.GetType().Name}'");
        animal.Say();
        return animal;
    }
}
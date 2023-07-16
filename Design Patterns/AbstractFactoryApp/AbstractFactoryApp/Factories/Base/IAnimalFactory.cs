namespace AbstractFactoryApp.Factories.Base;

using AbstractFactoryApp.Animals;

public interface IAnimalFactory {
    Dog GetDog(string? name = null);
    Cat GetCat(string? name = null);
    Horse GetHorse(string? name = null);
}
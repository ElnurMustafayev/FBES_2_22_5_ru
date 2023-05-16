using System.Collections;

namespace InterfacesApp2 {
    //public interface IAnimal {
    //    public void Walk();
    //    public void Fly();
    //    public void Swim() { }
    //}

    public interface IWalkable {
        public void Walk();
    }

    public interface ISwimmable {
        public void Swim();
    }

    public interface IFlyable {
        public void Fly();
    }


    public abstract class Animal {
        public string Name;

        public Animal(string name) {
            this.Name = name;
        }
    }


    public class Dog : Animal, IWalkable, ISwimmable {
        public Dog(string name) : base(name) {
        }

        public void Swim() {
            Console.WriteLine("Dog is swimming...");
        }

        public void Walk() {
            Console.WriteLine("Dog is walking...");
        }
    }

    public class Parrot : Animal, IWalkable, IFlyable {
        public Parrot(string name) : base(name) {
        }

        public void Fly() {
            Console.WriteLine("Parrot is flying...");
        }

        public void Walk() {
            Console.WriteLine("Parrot is walking...");
        }
    }

    public class Duck : Animal, IWalkable, ISwimmable, IFlyable {
        public Duck(string name) : base(name) {
        }

        public void Fly() {
            Console.WriteLine("Duck is flying...");
        }

        public void Swim() {
            Console.WriteLine("Duck is swimming...");
        }

        public void Walk() {
            Console.WriteLine("Duck is walking...");
        }
    }

    class Program {
        static void Main() {
            //List<Animal> animals = new List<Animal>() {
            //    new Dog("Barsik"),
            //    new Parrot("Kesha"),
            //    new Duck("Skrudj"),
            //};

            IEnumerable<IWalkable> walkables = new List<IWalkable>() {
                new Dog("Barsik"),
                new Parrot("Kesha"),
                new Duck("Skrudj"),
            };

            foreach (var walkable in walkables) {
                walkable.Walk();
            }

            IEnumerable<ISwimmable> swimmables = new List<ISwimmable>() {
                new Dog("Barsik"),
                //new Parrot("Kesha"),
                new Duck("Skrudj"),
            };

            foreach (var swimmable in swimmables) {
                swimmable.Swim();
            }

            IEnumerable<IFlyable> flyables = new List<IFlyable>() {
                //new Dog("Barsik"),
                new Parrot("Kesha"),
                new Duck("Skrudj"),
            };

            foreach (var flyable in flyables) {
                flyable.Fly();
            }
        }
    }
}
namespace Arv;
using Arv.Animals;
using Arv.Animals.Birds;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Arv Övning!");


        List<Animal> animals = new List<Animal> {

            new Horse(namn: "star", vikt: 10.0, age: 20, weight: 120),
            new Dog(namn: "morty", vikt: 10.0, age: 20,id: "Monty"),
            new Hedgehog(namn: "hedg008", vikt: 10.0, age: 20, nrOfSpikes: 100),
            new Horse(namn: "lucky", vikt: 10.0, age: 20, weight: 150),
            new Wolf(namn: "wolf", vikt: 10.0, age: 20),
            new Wolfman(namn: "wolfman", vikt: 10.0, age: 20),
            new Worm(namn: "snanke", vikt: 10.0, age: 20, isPoisonous: true),
            new Wolfman(namn: "wolfman2", vikt: 10.0, age: 20),
            new Bird(namn: "fly", vikt: 10.0, age: 20, wingSpan: 40.9)
        };


        foreach (Animal animal in animals)
        {

            Console.WriteLine(animal.GetType());
            animal.DoSound();
            Console.WriteLine(animal.Stats());

            if (animal is IPerson)
            {
                ((IPerson)animal).Talk();
            }

            Console.WriteLine("");
        }

        //9. F: Försök att lägga till en häst i listan av hundar. Varför fungerar inte det?
        // Because not same type
        // Argument 1: cannot convert from 'Arv.Horse' to 'Arv.Animals.Dog' (CS1503) (Arv)
        List<Dog> dogs = new List<Dog> {
            new Dog(namn: "morty", vikt: 10.0, age: 20,id: "boxer"),
            new Dog(namn: "morty", vikt: 10.0, age: 20,id: "elkbeer"),
          //  new Horse()
        };

        // 10.F: Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans ?
        // animal type

    }
}


namespace Arv;
using Arv.Animals;
using Arv.Animals.Birds;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Arv Övning!");


        List<Animal> animals = new List<Animal> {

            new Horse(weight: 120),
            new Dog(name: "Monty"),
            new Hedgehog(nrOfSpikes: 100),
            new Horse(weight: 150),
            new Wolf(),
            new Wolfman(),
            new Worm(isPoisonous: true),
            new Wolfman(),
            new Bird(wingSpan: 40.9)
        };


        foreach (Animal animal in animals)
        {

            Console.WriteLine(animal.GetType());
            animal.DoSound();

            animal.Stats();

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
            new Dog(name: "boxer"),
            new Dog(name: "elkbeer"),
          //  new Horse()
        };

        // 10.F: Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans ?
        // animal type

    }
}


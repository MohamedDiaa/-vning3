using System;
namespace Arv.Animals
{
	public class Worm: Animal
    {
        private bool isPoisonous;

        public Worm()
		{
		}

        public override void DoSound()
        {
            Console.WriteLine("it sound like a worm");

        }
    }
}


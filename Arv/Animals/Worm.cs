using System;
using System.Xml.Linq;

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

        public override string Stats()
        {
            string baseString = base.Stats();

            return $"{base.Stats}, isPoisonous: {isPoisonous}";
        }
    }
}


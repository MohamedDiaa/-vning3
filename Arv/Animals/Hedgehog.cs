using System;
using System.Xml.Linq;

namespace Arv.Animals
{
	public class Hedgehog: Animal
	{
        private int nrOfSpikes;

        public Hedgehog(string namn, double vikt, double age, int nrOfSpikes) : base(namn: namn, vikt: vikt, age: age)
        {
            this.nrOfSpikes = nrOfSpikes;
		}

        public override void DoSound()
        {
            Console.WriteLine("it sound like a Hedgehog");
        }

        public override string Stats()
        {
            string baseString = base.Stats();

            return $"{base.Stats()}, number of spikes: {nrOfSpikes}";
        }
    }
}


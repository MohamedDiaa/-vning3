using System;
using System.Xml.Linq;

namespace Arv.Animals.Birds
{
	public class Flamingo: Bird
    {

		private string species;

		public Flamingo(double wingSpan, string species): Bird(wingSpan: wingSpan)
		{
            this.species = species;
		}


        public override string Stats()
        {
            string baseString = base.Stats();

            return $"{base.Stats}, species: {species}";
        }
    }
}


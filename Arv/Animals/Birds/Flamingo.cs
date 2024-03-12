using System;
using System.Xml.Linq;

namespace Arv.Animals.Birds
{
	public class Flamingo: Bird
    {

		private string species;

       
		public Flamingo(string namn, double vikt, double age,double wingSpan, string species) : base(namn: namn, vikt: vikt,age:age,wingSpan: wingSpan)
		{
            this.species = species;
		}


        public override string Stats()
        {
            string baseString = base.Stats();

            return $"{base.Stats()}, species: {species}";
        }
    }
}


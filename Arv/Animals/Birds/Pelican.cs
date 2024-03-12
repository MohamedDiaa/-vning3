using System;
using System.Xml.Linq;

namespace Arv.Animals.Birds
{
	public class Pelican: Bird
    {
		private double weight;

		public Pelican(string namn, double vikt, double age,double wingSpan, double weight) : base(namn: namn, vikt: vikt,age:age,wingSpan: wingSpan)
		{            
            this.weight = weight;
		}

        public override string Stats()
        {
            string baseString = base.Stats();

            return $"{base.Stats()}, weight: {weight}";
        }
    }
}


using System;
using System.Xml.Linq;

namespace Arv.Animals.Birds
{
	public class Pelican: Bird
    {
		private double weight;

		public Pelican(double weight)
		{
            this.weight = weight;
		}

        public override string Stats()
        {
            string baseString = base.Stats();

            return $"{base.Stats}, weight: {weight}";
        }
    }
}


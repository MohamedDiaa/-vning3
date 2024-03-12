using System;
using System.Xml.Linq;

namespace Arv.Animals.Birds
{
	public class Pelican: Bird
    {
		private double weight;

		public Pelican(double wingSpan, double weight): base(wingSpan: wingSpan)
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


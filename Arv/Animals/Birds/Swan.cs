using System;
using System.Xml.Linq;

namespace Arv.Animals.Birds
{
	public class Swan: Bird
	{
		private string color;

		public Swan(string namn, double vikt, double age,double wingSpan, string color) : base(namn: namn, vikt: vikt,age:age,wingSpan: wingSpan)
		{
            this.color = color;
		}

        public override string Stats()
        {
            string baseString = base.Stats();

            return $"{base.Stats()}, color: {color}";
        }
    }
}


using System;
using System.Xml.Linq;

namespace Arv.Animals.Birds
{
	public class Swan: Bird
	{
		private string color;

		public Swan(double wingSpan, string color):  base(wingSpan: wingSpan)
		{
            this.color = color;
		}

        public override string Stats()
        {
            string baseString = base.Stats();

            return $"{base.Stats}, color: {color}";
        }
    }
}


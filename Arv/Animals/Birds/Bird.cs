using System;
using System.Xml.Linq;

namespace Arv.Animals
{
    //13. here we add the attributes shared by all the birds.

    public class Bird: Animal
	{
        protected double wingSpan;

        public Bird(string namn, double vikt, double age,double wingSpan) : base(namn: namn, vikt: vikt, age: age)
        {
            this.wingSpan = wingSpan;
		}

        public override void DoSound()
        {
            Console.WriteLine("it sound like a bird");
        }


        public override string Stats()
        {
            string baseString = base.Stats();

            return $"{base.Stats()}, wingspan: {wingSpan}";
        }
    }
}


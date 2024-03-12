using System;
namespace Arv.Animals
{
	public class Wolf: Animal
	{
		public Wolf(string namn, double vikt, double age): base(namn: namn, vikt: vikt,age:age)
		{
		}

        public override void DoSound()
        {
            Console.WriteLine("it sound like a Wolf");
        }
    }
}


using System;
namespace Arv.Animals
{
	public class Wolfman: Wolf, IPerson
	{
		public Wolfman(string namn, double vikt, double age) : base(namn: namn, vikt: vikt, age: age)
        {
		}

        public void Talk()
        {
			Console.WriteLine("wolfman time have come to rule over the world");
        }
    }
}


using System;
namespace Arv.Animals
{
	public class Wolfman: Wolf, IPerson
	{
		public Wolfman()
		{
		}

        public void Talk()
        {
			Console.WriteLine("wolfman time have come to rule over the world");
        }
    }
}


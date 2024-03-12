using System;
namespace Arv.Animals
{
	public class Wolf: Animal
	{
		public Wolf()
		{
		}

        public override void DoSound()
        {
            Console.WriteLine("it sound like a Wolf");
        }
    }
}


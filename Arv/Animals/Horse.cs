using System;
namespace Arv
{
	public class Horse: Animal
	{
		public Horse()
		{
		}

        public override void DoSound()
        {
            Console.WriteLine("it sound like a horse");
        }
    }
}


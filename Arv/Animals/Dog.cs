using System;
namespace Arv.Animals
{
	public class Dog: Animal
	{
        private string name;

		public Dog(string name)
		{
            this.name = name;
		}

        public override void DoSound()
        {
            Console.WriteLine("it sound like a dog");
        }

        public override string Stats()
        {
            string baseString = base.Stats();

            return $"{base.Stats}, name: {name}";
        }
    }
}


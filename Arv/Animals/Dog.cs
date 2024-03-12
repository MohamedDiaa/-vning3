using System;
namespace Arv.Animals
{
	public class Dog: Animal
	{
        private string id;

		public Dog(string namn, double vikt, double age, string id) : base(namn: namn, vikt: vikt,age:age)
		{
            this.id = id;
		}

        public override void DoSound()
        {
            Console.WriteLine("it sound like a dog");
        }

        public override string Stats()
        {
            string baseString = base.Stats();

            return $"{base.Stats()}, id: {id}";
        }
    }
}


using System;
namespace Arv
{
    // 14. here we add all attributs and methods that inhereted by all the animals
    public abstract class Animal
    {
        protected string namn;
        protected double vikt;
        protected double age;

        //

        protected Animal(string namn, double vikt, double age)
        {
            this.namn = namn;
            this.vikt = vikt;
            this.age = age;
        }

        public abstract void DoSound();

        public virtual string Stats()
        {

            return $"name: {namn}, vikt: {vikt}, ålder: {age}";
        }
    }
}


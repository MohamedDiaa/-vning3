using System;
namespace Arv
{
    // 14. here we add all attributs and methods that inhereted by all the animals
    public abstract class Animal
    {
        private string namn;
        private double vikt;
        private double ålder;

      
        public abstract void DoSound();

        public virtual string Stats() {

            return $"name: {namn}, vikt: {vikt}, älder: {ålder}";
        }
    }
}


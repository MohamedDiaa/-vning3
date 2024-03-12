using System;
namespace Arv
{
    // 14. here we add all attributs and methods that inhereted by all the animals
    public abstract class Animal
    {
        string namn;
        double vikt;
        double ålder;

       

        public abstract void DoSound();
    }
}


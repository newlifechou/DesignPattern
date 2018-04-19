using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    public static class AnimalFactory
    {
        public static AnimalBase CreateAnimal(string animalName)
        {
            switch (animalName)
            {
                case "cat":
                    return new Cat();
                case "dog":
                    return new Dog();
                default:
                    return null;
            }
        }
    }
}

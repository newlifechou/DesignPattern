using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalBase cat = AnimalFactory.CreateAnimal("cat");
            cat.ShowDetails();
            AnimalBase dog = AnimalFactory.CreateAnimal("dog");
            dog.ShowDetails();

            Console.Read();
        }
    }
}

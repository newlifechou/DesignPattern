using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    public class Dog:AnimalBase
    {
        public override void ShowDetails()
        {
            //base.DoSomething();
            Console.WriteLine("Cat operation");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Person : IAction
    {
        private string name;
        public Person(string n)
        {
            this.name = n;
        }
        public void Update()
        {
            Console.WriteLine($"{name} gets the message");
        }
    }
}

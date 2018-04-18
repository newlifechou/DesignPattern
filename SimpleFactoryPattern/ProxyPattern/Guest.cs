using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class Guest : IDo
    {
        private string name;
        public Guest(string n)
        {
            name = n;
        }
        public void Do()
        {
            Console.WriteLine(name + " want to say hello");
        }
    }
}

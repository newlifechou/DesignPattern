using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person() { Name = "xs.zhou" };
            Person p2 = (Person)p1.Clone();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            UniquePerson p = UniquePerson.GetInstance();
            p.Name = "xs.zhou";
            Console.WriteLine(p.Name);
            p = UniquePerson.GetInstance();
            Console.WriteLine(p.Name);
            Console.Read();
        }
    }
}

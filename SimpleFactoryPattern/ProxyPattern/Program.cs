using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Proxy p = new Proxy(new Guest("xs.zhou"));
            p.Do();

            Console.Read();
        }
    }
}

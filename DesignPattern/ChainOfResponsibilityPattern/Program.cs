using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler h1 = new FirstHandler();
            Handler h2 = new SecondHandler();
            h1.SetSuccessor(h2);

            h1.HandleRequest(9);
            h1.HandleRequest(15);

            Console.Read();
        }
    }
}

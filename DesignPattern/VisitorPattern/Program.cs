using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Success v1 = new Success();
            Man man = new Man();
            man.Accept(v1);
            Woman woman = new Woman();
            woman.Accept(v1);

            Console.Read();
        }
    }
}

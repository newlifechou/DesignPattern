using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory operateFactory = new DogDoFactory();
            DoBase dogDo = operateFactory.CreateDo();
            dogDo.Do();
            Console.Read();
        }
    }
}

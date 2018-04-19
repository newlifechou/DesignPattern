using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class ShenzhenStock : IStock
    {
        public void Buy()
        {
            Console.WriteLine("Shenzhen-Stock-Buy");
        }

        public void Sell()
        {
            Console.WriteLine("Shenzhen-Stock-Sell");
        }
    }
}

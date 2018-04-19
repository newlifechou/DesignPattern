using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class ShenzhenFund:IFund
    {
        public void Buy()
        {
            Console.WriteLine("Shenzhen-Fund-Buy");
        }

        public void Sell()
        {
            Console.WriteLine("Shenzhen-Fund-Sell");
        }
    }
}

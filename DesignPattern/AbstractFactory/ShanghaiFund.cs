using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class ShanghaiFund:IFund
    {
        public void Buy()
        {
            Console.WriteLine("Shanghai-Fund-Buy");
        }

        public void Sell()
        {
            Console.WriteLine("Shanghai-Fund-Sell");
        }
    }
}

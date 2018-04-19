using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class ShanghaiStock:IStock
    {
        public void Buy()
        {
            Console.WriteLine("Shanghai-Stock-Buy");
        }

        public void Sell()
        {
            Console.WriteLine("Shanghai-Stock-Sell");
        }
    }
}

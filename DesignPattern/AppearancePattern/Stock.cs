using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppearancePattern
{
    class Stock
    {
        private string stock_name;
        public Stock(string s)
        {
            stock_name = s;
        }
        public void Buy()
        {
            Console.WriteLine("Buy"+stock_name);
        }
        public void Sell()
        {
            Console.WriteLine("Sell" + stock_name);
        }

    }
}

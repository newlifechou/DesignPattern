using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppearancePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Fund myfund = new Fund();
            myfund.BuyFund();
            myfund.SellFund();

            Console.Read();
        }
    }
}

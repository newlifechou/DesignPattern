using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            string market = Properties.Settings.Default.Market;
            string className = $"AbstractFactory.{market}Factory";

            IFactory factory = (IFactory)Assembly.Load("AbstractFactory").CreateInstance(className);
            IStock stock = factory.CreateStock();
            stock.Buy();
            stock.Sell();
            IFund fund = factory.CreateFund();
            fund.Buy();
            fund.Sell();

            Console.Read();

        }
    }
}

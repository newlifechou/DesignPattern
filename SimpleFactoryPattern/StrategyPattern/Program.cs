using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            StrategyContext context1 = new StrategyContext(new StrategyA());
            context1.Run();
            StrategyContext context2 = new StrategyContext(new StrategyB());
            context2.Run();

            Console.Read();
        }
    }
}

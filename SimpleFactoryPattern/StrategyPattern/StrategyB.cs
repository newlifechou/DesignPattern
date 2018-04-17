using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class StrategyB:StrategyBase
    {
        public override void DoSomething()
        {
            Console.WriteLine("Strategy B");
        }
    }
}

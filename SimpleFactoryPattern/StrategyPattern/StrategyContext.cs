using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class StrategyContext
    {
        private  StrategyBase strategy;
        public StrategyContext(StrategyBase s)

        {
            this.strategy = s;
        }
        public void Run()
        {
            strategy.DoSomething();
        }
    }
}

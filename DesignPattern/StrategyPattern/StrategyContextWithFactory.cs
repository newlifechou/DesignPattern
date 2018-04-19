using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public  class StrategyContextWithFactory
    {
        private StrategyBase strategy = null;
        public StrategyContextWithFactory(string strategyString)
        {
            switch (strategyString)
            {
                case "A":
                    strategy = new StrategyA();
                    break;
                case "B":
                    strategy = new StrategyB();
                    break;
            }
        }
        public void Run()
        {
            strategy.DoSomething();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class ShenzhenFactory:IFactory
    {
        public IFund CreateFund()
        {
            return new ShenzhenFund();
        }

        public IStock CreateStock()
        {
            return new ShenzhenStock();
        }
    }
}

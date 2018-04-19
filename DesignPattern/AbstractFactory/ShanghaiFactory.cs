using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class ShanghaiFactory : IFactory
    {
        public IFund CreateFund()
        {
            return new ShanghaiFund();
        }

        public IStock CreateStock()
        {
            return new ShanghaiStock();
        }
    }
}

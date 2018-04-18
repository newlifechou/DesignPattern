using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class DogDoFactory : IFactory
    {
        public DoBase CreateDo()
        {
            return new DogDo();
        }
    }
}

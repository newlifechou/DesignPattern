using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    abstract class CityBuilder
    {
        public abstract void BuildPostOffice();
        public abstract void BuildSchool();
    }
}

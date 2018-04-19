using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class CityDirector
    {
        private CityBuilder cb;
        public CityDirector(CityBuilder cb)
        {
            this.cb = cb;
        }
        public void CreateCity()
        {
            cb.BuildPostOffice();
            cb.BuildSchool();
        }
    }
}

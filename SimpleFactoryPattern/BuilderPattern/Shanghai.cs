using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Shanghai:CityBuilder
    {
        public override void BuildPostOffice()
        {
            Console.WriteLine("build shanghai post office");
        }
        public override void BuildSchool()
        {
            Console.WriteLine("build shanghai school");
        }
    }
}

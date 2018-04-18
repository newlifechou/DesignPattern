using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Beijing:CityBuilder
    {
        public override void BuildPostOffice()
        {
            Console.WriteLine("build beijing post office");
        }
        public override void BuildSchool()
        {
            Console.WriteLine("build beijing school");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    class PersonA:TemplateBase
    {
        public override void One()
        {
            Console.WriteLine("A-One");
        }
        public override void Two()
        {
            Console.WriteLine("A-Two");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    class PersonB:TemplateBase
    {
        public override void One()
        {
            Console.WriteLine("B-One");
        }
        public override void Two()
        {
            Console.WriteLine("B-Two");
        }
    }
}

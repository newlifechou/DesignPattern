using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Mocha:Starbuck
    {
        public override void Show()
        {
            Console.WriteLine("Mocha Coffee");
        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Cappuccino:Starbuck
    {
        public override void Show()
        {
            Console.WriteLine("Cappcuccino");
        }

    }
}

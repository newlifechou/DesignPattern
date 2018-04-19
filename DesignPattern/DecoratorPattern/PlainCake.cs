﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class PlainCake:Snack
    {
        public override void Show()
        {
            base.Show();
            Console.WriteLine("add plain cake");
        }
    }
}

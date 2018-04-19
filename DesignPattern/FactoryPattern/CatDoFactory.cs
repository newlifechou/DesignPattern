﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class CatDoFactory : IFactory
    {
        public DoBase CreateDo()
        {
            return new CatDo();
        }
    }
}

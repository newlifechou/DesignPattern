using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    abstract class Prototype
    {
        public string Name { get; set; }
        public abstract Prototype Clone();
    }
}

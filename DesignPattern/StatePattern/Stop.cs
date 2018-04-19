using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Stop:State
    {
        public override void Handle()
        {
            Console.WriteLine("Stop");
        }
    }
}

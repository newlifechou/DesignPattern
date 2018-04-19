using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class Proxy : IDo
    {
        private Guest guest;
        public Proxy(Guest g)
        {
            guest = g;
        }
        public void Do()
        {
            guest.Do();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class CellPhone
    {
        protected Software software;
        public void SetSoftware(Software s)
        {
            this.software = s;
        }
        public virtual void RunSoftware()
        {
            software.Run();
        }

    }
}

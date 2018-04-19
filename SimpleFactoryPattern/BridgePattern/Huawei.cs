using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class Huawei : CellPhone
    {
        public override void RunSoftware()
        {
            software.Run();
        }
    }
}

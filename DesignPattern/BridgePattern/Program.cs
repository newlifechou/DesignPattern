using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CellPhone phone1 = new Samsung();
            CellPhone phone2 = new Huawei();
            phone1.SetSoftware(new WeChat());
            phone1.RunSoftware();

            phone2.SetSoftware(new QQ());
            phone2.RunSoftware();

            Console.Read();
        }
    }
}

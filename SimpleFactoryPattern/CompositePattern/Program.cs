using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Department c1 = new MiddleDepartment("生产部");
            c1.Add(new BottomDepartment("技术部"));
            c1.Add(new BottomDepartment("维护部"));
            c1.Display(1);

            Console.Read();

        }
    }
}

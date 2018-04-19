using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class BottomDepartment : Department
    {

        public BottomDepartment(string name) : base(name)
        {

        }
        public override void Add(Department c)
        {
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth)+ name);
        }

        public override void Remove(Department c)
        {
        }
    }
}

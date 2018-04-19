using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class MiddleDepartment : Department
    {
        private List<Department> children = new List<Department>();
        public MiddleDepartment(string name) : base(name)
        {

        }
        public override void Add(Department c)
        {
            children.Add(c);
        }

        public override void Remove(Department c)
        {
            children.Remove(c);
        }
        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);
            foreach (var c in children)
            {
                c.Display(depth + 1);
            }
        }

    }
}

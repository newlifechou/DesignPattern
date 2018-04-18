using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    abstract class Department
    {
        protected string name;
        public Department(string n)
        {
            name = n;
        }
        public abstract void Add(Department c);
        public abstract void Remove(Department c);
        public abstract void Display(int depth);
    }
}

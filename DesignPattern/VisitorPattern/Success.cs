using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    class Success : Action
    {
        public override void GetManMessage(Man man)
        {
            Console.WriteLine($"{man.GetType().Name}-{this.GetType().Name}");
        }

        public override void GetWomanMessage(Woman woman)
        {
            Console.WriteLine($"{woman.GetType().Name}-{this.GetType().Name}");
        }
    }
}

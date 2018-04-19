using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            StateContext context = new StateContext(new Stop());
            context.RequestState();
            context.CurrentState = new Start();
            context.RequestState();
            Console.Read();
        }
    }
}

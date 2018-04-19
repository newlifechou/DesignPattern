using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            RealMediator mediator = new RealMediator();
            American p1 = new American(mediator);
            Chinese p2 = new Chinese(mediator);

            mediator.American = p1;
            mediator.Chinese = p2;

            p1.Send("hello wolrd");
            p2.Send("yes ok");

            Console.Read();
        }
    }
}

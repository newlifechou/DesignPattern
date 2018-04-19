using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    class SecondHandler:Handler
    {
        public override void HandleRequest(int request)
        {
            if (request < 20)
            {
                Console.WriteLine("Second Process");
            }
            else if (successor != null)
            {
                successor.HandleRequest(request);
            }
        }
    }
}

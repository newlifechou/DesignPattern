using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    class FirstHandler : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request < 10)
            {
                Console.WriteLine("First Process");
            }
            else if (successor != null)
            {
                successor.HandleRequest(request);
            }
        }
    }
}

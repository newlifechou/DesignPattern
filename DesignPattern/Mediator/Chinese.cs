using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Chinese : Person
    {
        public Chinese(Mediator mediator) : base(mediator)
        {

        }
        public void Send(string message)
        {
            mediator.Send(message, this);
        }
        public void Notify(string message)
        {
            Console.WriteLine("Chinese get the message "+message);
        }
    }
}

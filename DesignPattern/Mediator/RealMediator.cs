using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class RealMediator : Mediator
    {
        private American person1;
        private Chinese person2;
        public American American
        {
            set
            {
                person1 = value;
            }
        }
        public Chinese Chinese
        {
            set
            {
                person2 = value;
            }
        }
        public override void Send(string message, Person person)
        {
            if (person1 == person)
            {
                person2.Notify(message);
            }
            else
            {
                person1.Notify(message);
            }
        }
    }
}

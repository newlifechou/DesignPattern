using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    abstract class Person
    {
        protected Mediator mediator;
        public Person(Mediator mediator)
        {
            this.mediator = mediator;
        }

    }
}

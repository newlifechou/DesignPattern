using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    abstract class Handler
    {
        protected Handler successor;
        public void SetSuccessor(Handler s)
        {
            this.successor = s;
        }
        public abstract void HandleRequest(int request);
    }
}

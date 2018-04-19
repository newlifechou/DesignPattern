using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
   public abstract class Action
    {
        public abstract void GetManMessage(Man man);
        public abstract void GetWomanMessage(Woman woman);
     }
}

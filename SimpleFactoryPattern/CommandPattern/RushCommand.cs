using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class RushCommand:Command
    {
        public RushCommand(Soldier s) : base(s)
        {

        }
        public override void ExcuteCommand()
        {
            soldier.Rush();
        }
    }
}

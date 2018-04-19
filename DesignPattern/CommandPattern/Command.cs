using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    abstract class Command
    {
        protected Soldier soldier;
        public Command(Soldier s)
        {
            this.soldier = s;
        }
        public abstract void ExcuteCommand();
    }
}

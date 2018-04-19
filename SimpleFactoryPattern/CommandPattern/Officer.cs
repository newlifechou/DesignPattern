using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Officer
    {
        private Command cmd;
        public Officer()
        {

        }
        public void SetOrder(Command cmd)
        {
            this.cmd = cmd;
        }
        public void Notify()
        {
            cmd.ExcuteCommand();
        }
    }
}

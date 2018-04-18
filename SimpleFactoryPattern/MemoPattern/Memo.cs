using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoPattern
{
    class Memo
    {
        private string state;
        public Memo(string s)
        {
            state = s;
        }

        public string State
        {
            get
            {
                return state;
            }
        }

    }
}

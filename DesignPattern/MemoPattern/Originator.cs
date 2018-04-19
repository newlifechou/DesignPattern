using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoPattern
{
    class Originator
    {
        public Originator()
        {
            State = "";
        }
        public string State { get; set; }
        public Memo CreateMemo()
        {
            return new Memo(State);
        }
        public void SetMemo(Memo memo)
        {
            State = memo.State;
        }
        public void Show()
        {
            Console.WriteLine(State);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator o = new Originator();
            o.State = "On";
            o.Show();

            Caretaker c = new Caretaker();
            c.CurrentMemo = o.CreateMemo();

            Console.WriteLine(c.CurrentMemo.State);

            o.State = "Off";
            o.Show();

            o.SetMemo(c.CurrentMemo);
            o.Show();

            Console.Read();
        }
    }
}

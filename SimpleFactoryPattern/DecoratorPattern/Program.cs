using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Starbuck coffee = new Latte();
            SweetCake cake1 = new SweetCake();
            cake1.SetFood(coffee);
            PlainCake cake2 = new PlainCake();
            cake2.SetFood(cake1);
            cake2.Show();

            Console.Read();
        }
    }
}

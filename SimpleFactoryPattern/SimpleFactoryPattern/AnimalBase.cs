using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    public class AnimalBase
    {
        public virtual void ShowDetails()
        {
            Console.WriteLine("this is operation base");
        }
    }
}

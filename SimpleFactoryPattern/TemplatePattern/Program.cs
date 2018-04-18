using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            TemplateBase run;
            run = new PersonA();
            run.TemplateMethod();

            run = new PersonB();
            run.TemplateMethod();


            Console.Read();
        }
    }
}

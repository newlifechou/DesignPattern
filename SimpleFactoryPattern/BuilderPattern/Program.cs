using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CityBuilder city;
            city = new Beijing();
            CityDirector director1 = new CityDirector(city);
            director1.CreateCity();

            city= new Shanghai();
            CityDirector director2 = new CityDirector(city);
            director2.CreateCity();
            Console.Read();
        }
    }
}

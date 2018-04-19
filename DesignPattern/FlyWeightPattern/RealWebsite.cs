using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightPattern
{
    class RealWebsite : Website
    {
        private string name = "";
        public RealWebsite(string n)
        {
            this.name = n;
        }
        public override void Use()
        {
            Console.WriteLine($"网站分类:{name}");
        }
    }
}

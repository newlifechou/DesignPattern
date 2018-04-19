using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WebsiteFactory factory = new WebsiteFactory();
            Website w1 = factory.GetWebsiteCategory("产品展示");
            w1.Use();

            Website w2 = factory.GetWebsiteCategory("公司介绍");
            w2.Use();

            Website w3 = factory.GetWebsiteCategory("产品展示");
            w3.Use();

            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppearancePattern
{
    class Fund
    {
        private Stock stock1;
        private Stock stock2;
        private Stock stock3;
        public Fund()
        {
            stock1 = new Stock("中国平安");
            stock2 = new Stock("格力电器");
            stock3 = new Stock("贵州茅台");
        }
        public void BuyFund()
        {
            stock1.Buy();
            stock2.Buy();
            stock3.Buy();
        }
        public void SellFund()
        {
            stock1.Sell();
            stock2.Sell();
            stock3.Sell();

        }

    }
}

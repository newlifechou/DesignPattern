using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Snack:Starbuck
    {
        private Starbuck food;
        public void SetFood(Starbuck food)
        {
            this.food = food;
        }
        public override void Show()
        {
            food.Show();
        }

    }
}

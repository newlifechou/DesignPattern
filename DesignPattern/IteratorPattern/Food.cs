using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class Food : IEnumerator<int>
    {
        public string[] foods;
        public Food(string[] foods)
        {
            this.foods = foods;
        }
        int position = -1;
        public int Current => position;

        object IEnumerator.Current => foods[position];

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            position++;
            return position < foods.Length;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}

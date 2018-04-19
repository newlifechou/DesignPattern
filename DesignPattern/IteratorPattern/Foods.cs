using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class Foods : IEnumerable<string>
    {
        private string[] foods;
        public Foods()
        {

        }
        public IEnumerator<string> GetEnumerator()
        {
            foreach (var food in foods)
            {
                yield return food;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var food in foods)
            {
                yield return food;
            }
        }
    }
}

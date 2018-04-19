using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class UniquePerson
    {
        public string Name { get; set; }
        private static UniquePerson person;
        public UniquePerson()
        {

        }
        private static readonly object syncRoot = new object();
        public static UniquePerson GetInstance()
        {
            if (person == null)
            {
                lock (syncRoot)
                {
                    if (person == null)
                    {
                        person = new UniquePerson();
                    }
                }
            }

            return person;
        }



    }
}

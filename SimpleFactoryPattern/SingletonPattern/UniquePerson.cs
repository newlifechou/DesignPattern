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
        public static UniquePerson GetInstance()
        {
            if (person == null)
            {
                person = new UniquePerson();
            }

            return person;
        }



    }
}

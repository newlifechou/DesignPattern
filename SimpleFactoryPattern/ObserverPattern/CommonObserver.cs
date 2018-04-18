using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class CommonObserver
    {
        private List<IAction> persons;
        public CommonObserver()
        {
            persons = new List<IAction>();
        }

        public void Add(IAction person)
        {
            persons.Add(person);
        }
        public void Remove(IAction person)
        {
            persons.Remove(person);
        }
        public void Notify()
        {
            foreach (var person in persons)
            {
                person.Update();
            }
        }
    }
}

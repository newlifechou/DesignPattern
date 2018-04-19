using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Jack");
            Person p2 = new Person("Peter");
            //CommonObserver observer = new CommonObserver();
            //observer.Add(p1);
            //observer.Add(p2);
            //observer.Notify();
            EventObserver observer = new EventObserver();
            observer.Notification += p1.Update;
            observer.Notification += p2.Update;
            observer.OnNotification();

            Console.Read();
        }
    }
}

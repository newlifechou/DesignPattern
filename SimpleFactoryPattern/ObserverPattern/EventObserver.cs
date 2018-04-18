using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public delegate void Update();
    class EventObserver
    {
        public event Update Notification;
        public void OnNotification()
        {
            Notification?.Invoke();
        }
    }
}

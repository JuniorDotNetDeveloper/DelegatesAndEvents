using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents.EventsWork
{
    public class EventArguments<T> : EventArgs
    {
        public T _Object { get; private set; }
        public EventArguments(T obj)
        {
            _Object = obj;
        }
    }
}

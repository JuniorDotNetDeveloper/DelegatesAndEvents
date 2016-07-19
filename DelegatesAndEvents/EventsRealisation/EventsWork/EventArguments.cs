using System;

namespace EventsRealisation.EventsWork
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

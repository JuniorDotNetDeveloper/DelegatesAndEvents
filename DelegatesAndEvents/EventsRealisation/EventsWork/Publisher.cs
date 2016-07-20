using System;
using Publisher.Abstraction;
using Publisher.Abstraction.Interfaces;

namespace EventsRealisation.EventsWork
{
    internal class Publisher<T> : IPublisher<T>
    {
        public event EventHandler<EventArguments<T>> DataPublisher;

        public void PublishData(T data)
    {
        if (data != null)
        {
            EventArguments<T> message = (EventArguments<T>)Activator.CreateInstance(typeof(EventArguments<T>), data);
            OnDataPunlisher(message);
        }
    }

    private void OnDataPunlisher(EventArguments<T> obj)
    {
        DataPublisher?.Invoke(this, obj);
    }
}
}

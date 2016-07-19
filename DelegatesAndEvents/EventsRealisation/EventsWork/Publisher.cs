using System;

namespace EventsRealisation.EventsWork
{
    internal class Publisher<T> : IPublisher<T>
    {
        public event EventHandler<EventArguments<T>> DataPublisher;

        public void PublishData(T data)
        {
            EventArguments<T> message = (EventArguments<T>)Activator.CreateInstance(typeof(EventArguments<T>), new object[] { data });
            OnDataPunlisher(message);
        }

        private void OnDataPunlisher(EventArguments<T> obj)
        {
            DataPublisher?.Invoke(this, obj);
        }
    }
}

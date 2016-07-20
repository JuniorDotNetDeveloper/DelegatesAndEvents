using System;

namespace EventsRealisation.EventsWork
{
    public class Publisher<T> : IPublisher<T>
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

using System;

namespace EventsRealisation.EventsWork
{
    public interface IPublisher<T>
    {
        event EventHandler<EventArguments<T>> DataPublisher;

        void PublishData(T data);
    }
}

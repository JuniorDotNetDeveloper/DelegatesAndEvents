using System;

namespace EventsRealisation.EventsWork
{
    interface IPublisher<T>
    {
        event EventHandler<EventArguments<T>> DataPublisher;

        void PublishData(T data);
    }
}

using System;

namespace Publisher.Abstraction.Interfaces
{
    public interface IPublisher<T>
    {
        event EventHandler<EventArguments<T>>  DataPublisher;

        void PublishData(T data);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents.EventsWork
{
    interface IPublisher<T>
    {
        event EventHandler<EventArguments<T>> DataPublisher;

        void PublishData(T data);
    }
}

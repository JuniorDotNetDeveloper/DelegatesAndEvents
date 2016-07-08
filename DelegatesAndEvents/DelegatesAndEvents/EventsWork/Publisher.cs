﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents.EventsWork
{
    class Publisher<T> : IPublisher<T>
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

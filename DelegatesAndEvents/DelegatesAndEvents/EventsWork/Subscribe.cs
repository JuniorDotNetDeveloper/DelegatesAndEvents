﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents.EventsWork
{
    class Subscribe<T> 
    {
        public IPublisher<T> Publisher { get; private set; }
        public Subscribe(IPublisher<T> publisher)
        {
            Publisher = publisher;
        }
    }
}

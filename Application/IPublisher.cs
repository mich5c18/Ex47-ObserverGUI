﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public interface IPublisher
    {
        void RegisterSubscriber(ISubscriber observer);
        void RemoveSubscriber(ISubscriber observer);
        void NotifySubscribers(string message);

    }
}

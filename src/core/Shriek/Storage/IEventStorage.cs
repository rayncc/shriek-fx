﻿using Shriek.Domains;
using Shriek.Events;
using System;
using System.Collections.Generic;
using System.Text;
using Shriek.Storage.Mementos;

namespace Shriek.Storage
{
    public interface IEventStorage
    {
        T GetMemento<T>(Guid aggregateId) where T : Memento;

        void SaveMemento(Memento memento);

        IEnumerable<Event> GetEvents(Guid aggregateId);

        void Save(AggregateRoot aggreagate);

        void Save<T>(T @event) where T : Event;
    }
}
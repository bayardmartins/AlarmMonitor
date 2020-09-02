using AlarmMonitor.Domain.Entities;
using AlarmMonitor.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmMonitor.Infrastructure.Repositories
{
    public class EventRepository : Repository<Event>, IEventRepository
    {
        private EventList Events;

        public EventRepository(EventList events)
            : base(events)
        {
            Events = events;
        }
    }
}

using AlarmMonitor.Domain.Entities;
using AlarmMonitor.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmMonitor.Infrastructure.Repositories
{
    public class EventUnitRepository : Repository<EventUnit>, IEventUnitRepository
    {
        private EventUnitList EventUnits;
        public EventUnitRepository(EventUnitList eventUnits)
            : base(eventUnits)
        {
            this.EventUnits = eventUnits;
        }

        public EventUnit GetEventUnitByCode(string code)
        {
            foreach(EventUnit eventUnit in EventUnits)
            {
                if(eventUnit.Code == code)
                {
                    return eventUnit;
                }
            }
            return null;
        }
    }
}

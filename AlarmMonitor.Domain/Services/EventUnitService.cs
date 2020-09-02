using AlarmMonitor.Domain.Entities;
using AlarmMonitor.Domain.Interfaces.Repositories;
using AlarmMonitor.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmMonitor.Domain.Services
{
    public class EventUnitService : EntityService<EventUnit>, IEventUnitService
    {
        public EventUnitService(IEventUnitRepository repository)
            : base(repository)
        {

        }
        public EventUnit GetEventUnitByCode(string code)
        {
            return (_repository as IEventUnitRepository).GetEventUnitByCode(code);
        }
    }
}

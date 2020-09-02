using AlarmMonitor.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmMonitor.Domain.Interfaces.Repositories
{
    public interface IEventUnitRepository : IRepository<EventUnit> 
    {
        EventUnit GetEventUnitByCode(string code);
    }
}

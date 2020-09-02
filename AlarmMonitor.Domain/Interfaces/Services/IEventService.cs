using AlarmMonitor.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmMonitor.Domain.Interfaces.Services
{
    public interface IEventService : IEntityService<Event>
    {
        void CreateEvent(int account, int eventCode, int panel,
            string partition, string zone, string user);


    }
}

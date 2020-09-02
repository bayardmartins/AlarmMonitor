using AlarmMonitor.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmMonitor.Application.Interfaces
{
    public interface IEventServiceApplication : IEntityServiceApplication<Event>
    {
        string HandleEvent(Byte[] eventBuffer, int panel);

    }
}

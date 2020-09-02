using AlarmMonitor.Domain.Entities;
using AlarmMonitor.Domain.Interfaces.Repositories;
using AlarmMonitor.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmMonitor.Domain.Services
{
    public class EventService : EntityService<Event>, IEventService
    {
        EventUnitService eventUnitService;
        public EventService(IEventRepository repository, IEventUnitRepository eventUnitRepository)
            : base(repository)
        {
            this.eventUnitService = new EventUnitService(eventUnitRepository);
        }

        public void CreateEvent(int account, int eventCode, int panel, string partition, string zone, string user)
        {
            Event newEvent = new Event();
            newEvent.Date = DateTime.Now;
            newEvent.PanelCode = panel;
            newEvent.Account = account.ToString();
            newEvent.SetEventUnit(this.GetEventUnitByCode(eventCode.ToString()));
            newEvent.Partition = partition;
            newEvent.Zone = zone;
            newEvent.User = user;

            if(newEvent.GetEventUnit() != null)
            {
                this.Add(newEvent);
            }
            else
            {
                throw new Exception("EventUnit not found!");
            }
        }

        public EventUnit GetEventUnitByCode(string code)
        {
            return this.eventUnitService.GetEventUnitByCode(code);
        }
    }
}

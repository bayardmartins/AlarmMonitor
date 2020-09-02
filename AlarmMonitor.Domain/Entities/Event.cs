using System;
using System.Collections.Generic;
using System.Text;

namespace AlarmMonitor.Domain.Entities
{
    public class Event : Entity
    {
        public DateTime Date { get; set;  }
        public int PanelCode { get; set; }
        public string Account { get; set; }
        public string EventCode { get => this.EventUnit.Code; }
        public string EventName { get => this.EventUnit.Description; }
        private EventUnit EventUnit { get; set; }
        public string Partition { get; set; }
        public string Zone { get; set; }
        public string User { get; set; }

        public void SetEventUnit(EventUnit eventUnit)
        {
            this.EventUnit = eventUnit;
        }

        public EventUnit GetEventUnit()
        {
            return this.EventUnit;
        }
    }
}

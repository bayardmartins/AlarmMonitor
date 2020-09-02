using System;
using System.Collections.Generic;
using System.Text;

namespace AlarmMonitor.Domain.Entities
{
    public class EventUnit : Entity
    {
        public string Code { get; set; }
        public string Description { get; set; }

        public EventUnit(string code, string description)
        {
            this.Code = code;
            this.Description = description;
        }
    }
}

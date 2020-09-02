using AlarmMonitor.Application.Interfaces;
using AlarmMonitor.Domain.Entities;
using AlarmMonitor.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AlarmMonitor.Application.Services
{
    public class PanelServiceApplication  : EntityServiceApplication<Panel>, IPanelServiceApplication
    {
        public PanelServiceApplication(IPanelService service)
            : base(service)
        { }

    }
}

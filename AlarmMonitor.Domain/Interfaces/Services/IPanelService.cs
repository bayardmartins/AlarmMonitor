using AlarmMonitor.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmMonitor.Domain.Interfaces.Services
{
    public interface IPanelService : IEntityService<Panel>
    {
        void CreatePanel(int code);
    }
}

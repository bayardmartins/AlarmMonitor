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
    public class PanelService : EntityService<Panel>, IPanelService
    {
        public PanelService(IPanelRepository repository)
            : base(repository)
        {

        }

        public void CreatePanel(int code)
        {
            Panel newPanel = new Panel();
            newPanel.Code = code;

            this.Add(newPanel);
        }
    }
}

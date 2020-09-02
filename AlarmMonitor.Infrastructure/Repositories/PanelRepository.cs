using AlarmMonitor.Domain.Entities;
using AlarmMonitor.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmMonitor.Infrastructure.Repositories
{
    public class PanelRepository : Repository<Panel>, IPanelRepository
    {
        private PanelList Panels;
        public PanelRepository(PanelList panels)
            : base(panels)
        {
            this.Panels = panels;
        }
    }
}

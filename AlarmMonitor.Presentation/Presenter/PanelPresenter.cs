using AlarmMonitor.Application;
using AlarmMonitor.Application.Interfaces;
using AlarmMonitor.Application.Services;
using AlarmMonitor.Domain.Entities;
using AlarmMonitor.Domain.Interfaces.Repositories;
using AlarmMonitor.Domain.Interfaces.Services;
using AlarmMonitor.Domain.Services;
using AlarmMonitor.Infrastructure.Context;
using AlarmMonitor.Presentation.Views;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmMonitor.Presentation.Presenter
{
    public class PanelPresenter
    {
        private AlarmMonitorContext _context;
        private ITcpServer tcpServer;
        private IEventService eventService;
        private IPanelService panelService;
        public PanelPresenter(AlarmMonitorContext Context)
        {
            this._context = Context;
            this.eventService = new EventService(_context.GetEventRepository(),_context.GetEventUnitRepository());
            this.panelService = new PanelService(_context.GetPanelRepository());
            this.tcpServer = new TcpServer(new EventServiceApplication(this.eventService,this.panelService));
            this.tcpServer.Setup();
        }

    }
}

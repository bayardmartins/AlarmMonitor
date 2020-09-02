using AlarmMonitor.Domain.Entities;
using AlarmMonitor.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmMonitor.Infrastructure.Context
{
    public class AlarmMonitorContext
    {
        private EventList Events { get; set; }
        private PanelList Panels { get; set; }
        private EventUnitList EventUnities { get; set; }
        public EventRepository eventRepository;
        public EventUnitRepository eventUnitRepository;
        public PanelRepository panelRepository;

        public AlarmMonitorContext()
        {
            this.Events = new EventList();
            this.Panels = new PanelList();
            this.EventUnities = new EventUnitList();

            this.eventRepository = new EventRepository(this.Events);
            this.eventUnitRepository = new EventUnitRepository(this.EventUnities);
            this.panelRepository = new PanelRepository(this.Panels);

            this.CreateEventUnities();
        }

        public EventList GetEvents() => this.Events;
        public PanelList GetPanels() => this.Panels;
        public EventUnitList GetEventUnits() => this.EventUnities;

        public EventRepository GetEventRepository() => this.eventRepository;
        public EventUnitRepository GetEventUnitRepository() => this.eventUnitRepository;
        public PanelRepository GetPanelRepository() => this.panelRepository;
        public void CreateEventUnities()
        {
            this.EventUnities.Add(new EventUnit("1130", "Disparo de zona"));
            this.EventUnities.Add(new EventUnit("3402", "Partição armada"));
            this.EventUnities.Add(new EventUnit("1402", "Partição desarmada"));
            this.EventUnities.Add(new EventUnit("1144", "Violação de tamper"));
            this.EventUnities.Add(new EventUnit("1110", "Incêndio"));
            this.EventUnities.Add(new EventUnit("1121", "Emergência silenciosa"));
            this.EventUnities.Add(new EventUnit("1100", "Emergência médica"));
            this.EventUnities.Add(new EventUnit("1300", "Falha de fonte auxiliar"));    
            this.EventUnities.Add(new EventUnit("1301", "Falha de energia elétrica"));
            this.EventUnities.Add(new EventUnit("1302", "Falha de bateria"));
            this.EventUnities.Add(new EventUnit("1333", "Falha de tensão no barramento"));
            this.EventUnities.Add(new EventUnit("1321", "Falha de sirene"));
            this.EventUnities.Add(new EventUnit("1143", "Falha de módulo expansor"));
            this.EventUnities.Add(new EventUnit("1350", "Falha de comunicação"));
            this.EventUnities.Add(new EventUnit("1142", "Curto circuito na zona"));
            this.EventUnities.Add(new EventUnit("3401", "Alarme armado"));
            this.EventUnities.Add(new EventUnit("1401", "Alarme desarmado"));
            this.EventUnities.Add(new EventUnit("3403", "Alarme auto armado"));
            this.EventUnities.Add(new EventUnit("3456", "Alarme armado forçado"));
            this.EventUnities.Add(new EventUnit("1570", "Zona inibida"));
            this.EventUnities.Add(new EventUnit("3130", "Restauro de zona"));
            this.EventUnities.Add(new EventUnit("3144", "Restauro de tamper"));
            this.EventUnities.Add(new EventUnit("3300", "Restauro fonte auxiliar"));
            this.EventUnities.Add(new EventUnit("3301", "Restauro energia elétrica"));
            this.EventUnities.Add(new EventUnit("3302", "Restauro de bateria"));
            this.EventUnities.Add(new EventUnit("3333", "Restauro tensão no barramento"));
            this.EventUnities.Add(new EventUnit("3321", "Restauro de sirene"));
            this.EventUnities.Add(new EventUnit("3143", "Restauro módulo expansor"));
            this.EventUnities.Add(new EventUnit("3142", "Restauro curto circuito"));
        }
    }
}

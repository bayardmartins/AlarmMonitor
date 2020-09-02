using AlarmMonitor.Application.Interfaces;
using AlarmMonitor.Domain.Entities;
using AlarmMonitor.Domain.Interfaces.Services;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace AlarmMonitor.Application.Services
{
    public class EventServiceApplication : EntityServiceApplication<Event>, IEventServiceApplication
    {
        private IPanelService PanelService;
        public EventServiceApplication(IEventService service, IPanelService panelService)
            : base(service)
        {
            this.PanelService = panelService;   
        }

        public string HandleEvent(Byte[] eventBuffer, int panel)
        {
            Byte[] ct = new Byte[] { eventBuffer[1], eventBuffer[2] };
            Byte[] ev = new Byte[] { eventBuffer[3], eventBuffer[4] };

            int account = Util.MyConverter(ct);
            int eventCode = Util.MyConverter(ev);
            string partition = eventBuffer[5].ToString();
            string zone = eventBuffer[6].ToString();
            string user = eventBuffer[7].ToString();
            string check = eventBuffer[8].ToString();

            try
            {
                (service as IEventService).CreateEvent(account, eventCode, panel, partition, zone, user);
            }
            catch
            {
                //TODO: disparar mensagem
            }

            string data = check.ToString();

            return data;
        }

        public void HandleClient(TcpClient client)
        {
            Byte[] clientBuffer = new Byte[4];
            Byte[] eventBuffer = new Byte[9];

            NetworkStream stream = client.GetStream();

            stream.Read(clientBuffer, 0, clientBuffer.Length);

            PanelService.CreatePanel(clientBuffer[2]);

            int i;

            while ((i = stream.Read(eventBuffer, 0, eventBuffer.Length)) != 0)
            {
                byte[] msg = Encoding.ASCII.GetBytes(this.HandleEvent(eventBuffer, clientBuffer[2]));
                stream.Write(msg, 0, msg.Length);
            }

            client.Close();
        }
    }
}

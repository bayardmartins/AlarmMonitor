using AlarmMonitor.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AlarmMonitor.Application.Services
{
    public class TcpServer : ITcpServer
    {
        EventServiceApplication eventService;

        public TcpServer(EventServiceApplication eventService)
        {
            this.eventService = eventService;
        }

        public void Setup()
        {
            TaskFactory tf = new TaskFactory();
            Task server = tf.StartNew(Serve);
        }

        public void Serve()
        {
            TcpListener server = null;
            try
            {
                Int32 port = 9000;
                IPAddress localAddr = IPAddress.Parse("127.0.0.1");

                server = new TcpListener(localAddr, port);

                server.Start();

                int i = 0;
                
                //Aqui eu setei fixo para 4 devido ao comportamento do emulador
                //Em uma aplicação haveria uma validação de negócio
                while (i < 4)
                {
                    i++;
                    TcpClient client = server.AcceptTcpClient();
                    new Thread(() => eventService.HandleClient(client)).Start();
                }
            }
            catch (SocketException e)
            {
                throw new Exception("SocketException: {0}", e);
            }
            finally
            {
                server.Stop();
            }

            Console.Read();
        }
    }
}
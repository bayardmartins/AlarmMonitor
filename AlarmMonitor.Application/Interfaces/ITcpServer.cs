using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmMonitor.Application.Interfaces
{
    public interface ITcpServer
    {
        void Setup();
        void Serve();
    }
}

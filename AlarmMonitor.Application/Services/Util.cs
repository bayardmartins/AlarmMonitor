using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmMonitor.Application.Services
{
    public static class Util
    {
        public static int MyConverter(Byte[] btArray)
        {
            int result = btArray[0] * 16 * 16 + btArray[1];
            return result;
        }
    }
}

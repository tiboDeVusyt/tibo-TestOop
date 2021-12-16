using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tibo_TestOop.Models
{
    public static class LoggerService
    {
        private static LogMessages[] logs;
        public static LogMessages[] Logs { get; set; }
        static LoggerService()
        {
            Logs = new LogMessages[0];
        }
        public static void AddLogMessage(LogMessages LogMessage)
        {
            Array.Resize(ref logs, Logs.Length+1);
            logs[Logs.Length] = LogMessage;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tibo_TestOop.Models
{
    public class LogMessages
    {
        private int MaxId = 0;
        public string _boodschap { get; set; }
        public LogMessages(string Boodschap)
        {
            Id = GenereerId();
            _boodschap = Boodschap;
        }
        public int Id { get; set; }
        public int GenereerId()
        {
            foreach (LogMessages messages in LoggerService.Logs)
            {
                if (MaxId<= messages.Id)
                {
                    MaxId = messages.Id;
                }
            }
            return (MaxId+1);
        }
    }
}

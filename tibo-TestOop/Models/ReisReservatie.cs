using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tibo_TestOop.interfaces;

namespace tibo_TestOop.Models
{
    public class ReisReservatie:LogMessage
    {
        public ReisReservatie(LogMessages logMessage ,Persoon persoon,Reis reis , ReisBureau reisBureau)
        {
            persoon1 = persoon;
            _reis = reis;    
            _reisBureau = reisBureau;
            LoggerService.AddLogMessage(logMessage);
        }
        public Reis _reis { get; set; }
        public Persoon persoon1 { get; set; }
        public ReisBureau _reisBureau { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tibo_TestOop.Models
{
    public class ReisBureau
    {
        public ReisBureau(adres Adres,string Name)
        {
            adres = Adres;
            name = Name;
        }
        public adres adres { get; set; }
        public string name { get; set; }
    }
}

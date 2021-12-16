using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tibo_TestOop.Models
{
    public class adres
    {
        public adres(string gemeente,string huis,int poscode,string straat)
        {
            Gemeente = gemeente;
            HuisNr= huis;
            Postcode = poscode;
            Straat = straat;
        }
        public string Gemeente { get; set; }
        public string HuisNr { get; set; }
        public int Postcode { get; set; }
        public string Straat { get; set; }
    }
}

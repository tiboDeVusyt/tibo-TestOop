using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tibo_TestOop.Models
{
    public abstract class Reis
    {
        public readonly int aantalDagen;
        public double BasisPrijs { get; set; } = 40;
        public double Prijs { get; set; }
        public int aantalPersonen { get; set; }

        private DateTime _terugKeerDatum;

        public DateTime terugKeerDatum
        {
            get { return _terugKeerDatum; }
            set 
            {
                if (value>DateTime.Now && value > vertrekDatum)
                {
                    _terugKeerDatum = value;
                }
            }
        }
        private DateTime _vertrekDatum;

        public DateTime vertrekDatum
        {
            get { return _vertrekDatum; }
            set 
            {
                if (value>DateTime.Now)
                {
                    _vertrekDatum = value;
                }
            }
        }

        public Reis(int AantalPersonen,DateTime TerugKeerDatum ,DateTime VertrekDatum)
        {
            aantalPersonen = AantalPersonen;
            vertrekDatum = VertrekDatum;
            terugKeerDatum = TerugKeerDatum;
            TimeSpan ts = terugKeerDatum - VertrekDatum;
            aantalDagen = ts.Days;
        }
        public virtual double BerekenPrijs()
        {
            Prijs = aantalDagen * BasisPrijs;
            return Prijs ; 
        }
    }
}

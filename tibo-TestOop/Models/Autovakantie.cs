using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tibo_TestOop.Models
{
    internal class Autovakantie:Reis
    {
        private double ExtraPrijsHuurAuto = 10;
        protected bool _eigenWagen { get; set; }

        public Autovakantie(int AantalPersonen, DateTime TerugKeerDatum, DateTime VertrekDatum,bool EigenWagen) : base(AantalPersonen, TerugKeerDatum, VertrekDatum)
        {
            _eigenWagen = EigenWagen;
            aantalPersonen = AantalPersonen;
        }
        private double AantalAuto;

        public override double BerekenPrijs()
        {
            if (aantalPersonen>5)
            {
                aantalPersonen -= 5;
                AantalAuto++;
            }
            Prijs += AantalAuto * aantalDagen*ExtraPrijsHuurAuto;
            return Prijs;
        }
    }
}

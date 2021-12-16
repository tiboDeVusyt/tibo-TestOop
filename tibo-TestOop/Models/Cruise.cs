using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tibo_TestOop.Models
{
    internal class Cruise : Reis
    {
        public const double CruisePrijsExtraDagKost = 10;
        private bool _vip = false;
        public Cruise(int AantalPersonen, DateTime TerugKeerDatum, DateTime VertrekDatum,bool Vip) : base(AantalPersonen, TerugKeerDatum, VertrekDatum)
        {
            _vip = Vip;
        }
        public override double BerekenPrijs()
        {
            //for (int i = 0; i < aantalPersonen; i++)
            //{
                if (_vip)
                {
                    Prijs += CruisePrijsExtraDagKost * 1.5;
                }
                else
                {
                    Prijs += CruisePrijsExtraDagKost * 1;
                }
            //}
            return Prijs;
        }
        public void CruiseMethod()
        { }
    }
}

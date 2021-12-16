using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tibo_TestOop.Models
{
    internal class VliegtuigVakantie : Reis
    {
        public double _vliegthuigTicketPrijs;
        public VliegtuigVakantie(int AantalPersonen, DateTime TerugKeerDatum, DateTime VertrekDatum,double VliegthuigTicketPrijs) : base(AantalPersonen, TerugKeerDatum, VertrekDatum)
        {
            _vliegthuigTicketPrijs = VliegthuigTicketPrijs;
        }
        public override double BerekenPrijs()
        {
            
            Prijs += _vliegthuigTicketPrijs;
            return Prijs;
        }

    }
}

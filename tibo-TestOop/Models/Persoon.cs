using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tibo_TestOop.Models
{
    public class Persoon
    {
        public Persoon(adres adres,string naam,string achternaam)
        {
            Adres = adres;
            FirstName = naam;
            LastName = achternaam;
        }
        public adres Adres { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = $"{FirstName} {LastName}"; }
        }

    }
}

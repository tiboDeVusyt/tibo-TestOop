using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tibo_TestOop.Models;
using tibo_TestOop.interfaces;

namespace tibo_TestOop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region aanmaken
            adres[] Adres = new adres[3];
            Adres[0] = new adres("asse", "40", 1730, "roost");
            Adres[1] = new adres("wemmel", "48", 3560, "roadway");
            Adres[2] = new adres("brussel", "69", 1562, "random");

            Persoon[] persoons = new Persoon[3];
            persoons[0] = new Persoon(Adres[0], "tibo", "DE Vuyst");
            persoons[1] = new Persoon(Adres[1], "Kenan", "Achternaam");
            persoons[2] = new Persoon(Adres[2], "adward", "Decimal kleine");

            ReisBureau[] reisBureaus = new ReisBureau[2];
            reisBureaus[0] = new ReisBureau(Adres[0],"EWA.INC");
            reisBureaus[1] = new ReisBureau(Adres[1], "Kenan's Study");

            Cruise[] cruise = new Cruise[1];
            cruise[0] =new Cruise(15, new DateTime(2022, 6, 20),new DateTime(2022 , 8 ,6), true);

            Autovakantie[] autoVakantie = new Autovakantie[1];
            autoVakantie[0] = new Autovakantie(5, new DateTime(2022, 6, 20), new DateTime(2022, 8, 6), false);

            VliegtuigVakantie[] vliegtuigVakanties = new VliegtuigVakantie[1];
            vliegtuigVakanties[0] = new VliegtuigVakantie(120, new DateTime(2022, 5, 18), new DateTime(2022, 10, 15), 2489);

            LogMessages[] messages = new LogMessages[3];
            messages[0] = new LogMessages("random booschap om door te geven");
            messages[1] = new LogMessages("2de random message");
            messages[2] = new LogMessages("de boodschap is doorgegeven");
            #endregion

            ReisReservatie[] reisReservaties = new ReisReservatie[3];
            reisReservaties[0] = new ReisReservatie(messages[0], persoons[0], autoVakantie[0], reisBureaus[0]);
            reisReservaties[1] = new ReisReservatie(messages[1], persoons[1], vliegtuigVakanties[0], reisBureaus[0]);
            reisReservaties[2] = new ReisReservatie(messages[2], persoons[2], cruise[0], reisBureaus[1]);
        }
    }
}

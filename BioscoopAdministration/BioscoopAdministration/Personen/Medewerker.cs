using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioscoopAdministration
{
    public class Medewerker : Persoon
    {
        public int MedewerkerID { get; private set; }
        private string Wachtwoord;

        public Medewerker
            (
                string naam, 
                string adres, 
                string woonplaats, 
                DateTime geboortedatum, 
                int id, 
                string wachtwoord
            ) : base(naam, adres, woonplaats, geboortedatum)
        {
            MedewerkerID = id;
            Wachtwoord = wachtwoord;
        }
        /// <summary>
        /// Controleer of het meegegeven wachtwoord overeenkomt met wachtwoord field
        /// </summary>
        /// <param name="wachtwoord"></param>
        /// <returns></returns>
        public bool WachtwoordCorrect(string wachtwoord)
        {
            if (wachtwoord == Wachtwoord) return true;
            return false;
        }
        
        public override string ToString()
        {
            return "Medewerker " + MedewerkerID;
        }
    }
}

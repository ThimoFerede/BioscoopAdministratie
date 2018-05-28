using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioscoopAdministration
{
    public abstract class Persoon
    {
        public string Naam { get; private set; }
        public string Adres { get; private set; }
        public string Woonplaats { get; private set; }
        private DateTime geboortedatum;
        public DateTime Geboortedatum { get { return new DateTime(geboortedatum.Year, geboortedatum.Month, geboortedatum.Day); }}

        public Persoon(string naam, string adres, string woonplaats, DateTime geboortedatum)
        {
            if (geboortedatum == null)
            {
                throw new ArgumentNullException("geboortedatum", "geboortedatum mag niet null zijn");
            }
            this.Naam = naam;
            this.Adres = adres;
            this.Woonplaats = woonplaats;
            this.geboortedatum = geboortedatum;
        }

        public abstract override string ToString();
    }
}

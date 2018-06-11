using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BioscoopAdministration.Producten;

namespace BioscoopAdministration
{
    [Serializable]
    public class Bezoeker : Persoon, IInfo
    {
        public Bestelling Bestelling { get; private set; }
        public string InfoString
        {
            get
            {
                return "Bezoeker: " + base.Naam + Environment.NewLine + " Woonplaats: " + base.Adres + " " + base.Woonplaats;
            }
        }

        public string InfoLijstNaam
        {
            get
            {
                return "Bestelling";
            }
        }
        public List<object> InfoLijst
        {
            get
            {
                return new List<object>() { Bestelling };
            }
        }
        public Bezoeker
            (
                string naam,
                string adres,
                string woonplaats,
                DateTime geboortedatum
            ) : base(naam, adres, woonplaats, geboortedatum)
        {
            
        }

        public void VoegBestellingToe(Bestelling bestelling)
        {
            this.Bestelling = bestelling ?? throw new ArgumentNullException();
        }

        public override string ToString()
        {
            return base.Naam;
        }
    }
}

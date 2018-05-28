using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BioscoopAdministration.Producten;

namespace BioscoopAdministration
{
    public class Bezoeker : Persoon
    {
        public Bestelling Bestelling { get; private set; }
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
            this.Bestelling = bestelling;
        }

        public override string ToString()
        {
            return base.Naam;
        }
    }
}

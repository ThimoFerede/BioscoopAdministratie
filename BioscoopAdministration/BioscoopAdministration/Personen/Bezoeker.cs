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
        public Bestelling bestelling { get; private set; }
        public Bezoeker
            (
                string naam,
                string adres,
                string woonplaats,
                DateTime geboortedatum,
                Bestelling bestelling
            ) : base(naam, adres, woonplaats, geboortedatum)
        {
            this.bestelling = bestelling;
        }

        public override string ToString()
        {
            return base.Naam;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioscoopAdministration.Producten
{
    public class Bestelling : IPrice
    {
        public int BestellingsID { get; private set; }
        public Bezoeker Bezoeker { get; private set; }

        public int Price
        {
            get { return 0; }
        }
        public Bestelling(int bestellingsID, Bezoeker bezoeker)
        {
            BestellingsID = bestellingsID;
            Bezoeker = bezoeker;
            Bezoeker.VoegBestellingToe(this);
        }

        public override string ToString()
        {
            return "Bestelling " + BestellingsID;
        }
    }
}

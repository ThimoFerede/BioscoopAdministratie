using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Films
{
    public class Stoel
    {
        public int Rij { get; private set; }
        public int Stoelnummer { get; private set; }
        public bool VIPplaats { get; private set; }

        public Stoel(int rij, int stoelnummer, bool vipplaats)
        {
            Rij = rij;
            Stoelnummer = stoelnummer;
            VIPplaats = vipplaats;
        }

        public override string ToString()
        {
            return "Rij: " + Rij + " - Stoelnummer: " + Stoelnummer + " - VIP plaats: " + VIPplaats;
        }
    }
}

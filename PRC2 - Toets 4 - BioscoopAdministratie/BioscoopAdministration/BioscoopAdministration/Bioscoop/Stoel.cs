using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioscoopAdministration
{
    [Serializable]
    public class Stoel : IInfo
    {
        public int Rij { get; private set; }
        public int Stoelnummer { get; private set; }
        public bool VIPplaats { get; private set; }

        public string InfoString
        {
            get
            {
                string info = "Rij:" + Rij + Environment.NewLine + "Stoel:" + Stoelnummer;
                if (VIPplaats) info += Environment.NewLine + "Vip";
                return info;
            }
        }

        public string InfoLijstNaam
        {
            get
            {
                return "";
            }
        }
        public List<object> InfoLijst
        {
            get
            {
                return new List<object>();
            }
        }

        public Stoel(int rij, int stoelnummer, bool vipplaats)
        {
            Rij = rij;
            Stoelnummer = stoelnummer;
            VIPplaats = vipplaats;
        }

        public override string ToString()
        {
            string info = "Rij:" + Rij + " - Nr:" + Stoelnummer;
            if (VIPplaats) info += " - VIP";
            return info;
        }
    }
}

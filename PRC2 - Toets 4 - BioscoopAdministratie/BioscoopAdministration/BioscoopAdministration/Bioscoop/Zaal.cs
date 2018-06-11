using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BioscoopAdministration.Producten;

namespace BioscoopAdministration
{
    [Serializable]
    public class Zaal : IInfo
    {
        public int Zaalnummer { get; private set; }
        public Bioscoopvertoning.Filmkwaliteit FilmKwaliteit { get; private set; }
        public List<Stoel> Stoelen { get; private set; }
        public string InfoString
        {
            get
            {
                string info = "Zaal: " + Zaalnummer + Environment.NewLine + "Kwaliteit: " + FilmKwaliteit;
                return info;
            }
        }

        public string InfoLijstNaam
        {
            get
            {
                return "Stoelen";
            }
        }
        public List<object> InfoLijst
        {
            get
            {
                return Stoelen.Cast<object>().ToList();
            }
        }

        public Zaal (int zaalnummer, Bioscoopvertoning.Filmkwaliteit filmkwaliteit, int aantal_rijen_stoelen, int aantal_stoelen_per_rij, int aantal_VIP_rijen, int aantal_VIP_per_rij)
        {
            Zaalnummer = zaalnummer;
            FilmKwaliteit = filmkwaliteit;
            Stoelen = new List<Stoel>();
            GenereerStoelen( aantal_rijen_stoelen, aantal_stoelen_per_rij, aantal_VIP_rijen, aantal_VIP_per_rij);
        }

        public void GenereerStoelen(int aantal_rijen_stoelen, int aantal_stoelen_per_rij, int aantal_VIP_rijen, int aantal_VIP_per_rij)
        {
            for(int i = 1; i <= aantal_rijen_stoelen; i++)
            {
                for(int j = 1; j <= aantal_stoelen_per_rij; j++)
                {
                    Stoel s = new Stoel(i, j, false);
                    Stoelen.Add(s);
                }
            }
            for (int k = 1; k <= aantal_VIP_rijen; k++)
            {
                for(int l = 1; l <= aantal_VIP_per_rij; l++)
                {
                    Stoel s = new Stoel(k + aantal_rijen_stoelen, l, true);
                    Stoelen.Add(s);
                }
            }
        }

        public override string ToString()
        {
            return "Zaal: " + Zaalnummer + " - Filmkwaliteit: " + FilmKwaliteit;
        }
    }
}

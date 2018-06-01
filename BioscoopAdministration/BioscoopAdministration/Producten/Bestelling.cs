using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioscoopAdministration.Producten
{
    public class Bestelling : IPrice, IInfo
    {
        public Persoon Klant { get; private set; }
        public Bioscoopvertoning Bioscoopvertoning { get; private set; }
        public Stoel Stoel { get; private set; }
        public string InfoString
        {
            get
            {
                return "Bestelling van: " + Klant.Naam + Environment.NewLine + Bioscoopvertoning.InfoString + Environment.NewLine + Stoel.InfoString;
            }
        }

        public string InfoLijstNaam
        {
            get
            {
                return "Vertoning";
            }
        }
        public List<object> InfoLijst
        {
            get
            {
                return new List<object>() { Bioscoopvertoning};
            }
        }

        public double Price
        {
            get
            {
                if (Stoel.VIPplaats) return Bioscoopvertoning.Prijs + 4;
                else return Bioscoopvertoning.Prijs;
            }
        }
        /// <summary>
        /// Maak een bestelling aan
        /// Wanneer de klant een bezoeker of lid is wordt deze bestelling automatisch aan de klant toegevoegd
        /// </summary>
        /// <param name="bestellingsID"></param>
        /// <param name="klant"></param>
        public Bestelling(Persoon klant, Bioscoopvertoning bioscoopvertoning, Stoel stoel)
        {
            Klant = klant ?? throw new ArgumentNullException();
            Bioscoopvertoning = bioscoopvertoning ?? throw new ArgumentNullException();
            Stoel = stoel ?? throw new ArgumentNullException();
            if (klant is Bezoeker) (klant as Bezoeker).VoegBestellingToe(this);
            if (klant is Lid) (klant as Lid).VoegBestellingToe(this);
            bioscoopvertoning.VoegBestellingToe(this);
        }

        public override string ToString()
        {
            return "Bestelling " + Bioscoopvertoning.Titel + " voor " + Klant.Naam;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioscoopAdministration.Producten
{
    public class Bestelling : IPrice
    {
        public int BestellingsID { get; private set; }
        public Persoon Klant { get; private set; }
        public Bioscoopvertoning Bioscoopvertoning { get; private set; }
        public Stoel Stoel { get; private set; }
        public Zaal Zaal { get; private set; }

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
        public Bestelling(int bestellingsID, Persoon klant, Bioscoopvertoning bioscoopvertoning, Zaal zaal, Stoel stoel)
        {
            BestellingsID = bestellingsID;
            Klant = klant ?? throw new ArgumentNullException();
            Bioscoopvertoning = bioscoopvertoning ?? throw new ArgumentNullException();
            Zaal = zaal ?? throw new ArgumentNullException();
            Stoel = stoel ?? throw new ArgumentNullException();
            if (klant is Bezoeker) (klant as Bezoeker).VoegBestellingToe(this);
            if (klant is Lid) (klant as Lid).VoegBestellingToe(this);
            bioscoopvertoning.VoegBestellingToe(this);
        }

        public override string ToString()
        {
            return "Bestelling " + BestellingsID;
        }
    }
}

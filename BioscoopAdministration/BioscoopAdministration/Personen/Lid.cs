using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BioscoopAdministration.Producten;

namespace BioscoopAdministration
{
    public class Lid : Persoon
    {
        public List<Bestelling> Bestellingen { get; private set; }
        public List<Uitlening> Uitleningen { get; private set; }
        public string Gebruikersnaam { get; private set; }
        private string Wachtwoord;
        public Lid
            (
                string naam,
                string adres,
                string woonplaats,
                DateTime geboortedatum,
                string gebruikersnaam,
                string wachtwoord
            ) : base(naam, adres, woonplaats, geboortedatum)
        {
            Gebruikersnaam = gebruikersnaam;
            Wachtwoord = wachtwoord;
            Bestellingen = new List<Bestelling>();
            Uitleningen = new List<Uitlening>();
        }
        /// <summary>
        /// Controleer of het meegegeven wachtwoord overeenkomt met wachtwoord field
        /// </summary>
        /// <param name="wachtwoord"></param>
        /// <returns></returns>
        public bool WachtwoordCorrect(string wachtwoord)
        {
            if (wachtwoord == Wachtwoord) return true;
            return false;
        }
        /// <summary>
        /// Voeg een bestelling toe aan de lijst
        /// De bestelling mag niet null zijn
        /// </summary>
        /// <param name="bestelling"></param>
        public void VoegBestellingToe(Bestelling bestelling)
        {
            if (bestelling == null) throw new ArgumentNullException("bestelling", "bestelling mag niet null zijn");
            Bestellingen.Add(bestelling);
        }
        /// <summary>
        /// Verwijderd een bestelling en geeft het resultaat terug
        /// De bestelling mag niet null zijn
        /// </summary>
        /// <param name="bestelling"></param>
        /// <returns>
        /// Wel of niet verwijderd
        /// </returns>
        public bool AnnuleerBestelling(Bestelling bestelling)
        {
            if (bestelling == null) throw new ArgumentNullException("bestelling", "bestelling mag niet null zijn");
            return Bestellingen.Remove(bestelling);
        }
        /// <summary>
        /// Voeg een uitlening toe aan de lijst
        /// De uitlening mag niet null zijn
        /// </summary>
        /// <param name="uitlening"></param>
        public void VoegUitleningToe(Uitlening uitlening)
        {
            if (uitlening == null) throw new ArgumentNullException("uitlening", "uitlening mag niet null zijn");
            Uitleningen.Add(uitlening);
        }

        public override string ToString()
        {
            return base.Naam;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BioscoopAdministration.Producten;

namespace BioscoopAdministration
{
    public class Bioscoopvertoning : Film
    {
        public DateTime Begintijd { get; private set; }
        public DateTime Eindtijd { get { return Begintijd.AddMinutes(base.Speelduur); } }
        public Filmkwaliteit Film_kwaliteit { get; private set; }
        public Zaal BioscoopZaal { get; private set; }
        public List<Bestelling> Bestellingen { get; private set; }
        public double Prijs { get; private set; }

        public Bioscoopvertoning(
            string titel, 
            int jaar, 
            int speelduur, 
            string taal, 
            int leeftijdscategorie, 
            List<Genre> lijstGenres, 
            DateTime begintijd, 
            Filmkwaliteit filmkwaliteit, 
            Zaal zaal,
            double prijs) 
            
            : base(titel, jaar, speelduur, taal, leeftijdscategorie, lijstGenres)
        {
            Begintijd = begintijd;
            BioscoopZaal = zaal;
            Film_kwaliteit = filmkwaliteit;
            Bestellingen = new List<Bestelling>();
            Prijs = prijs;
        }

        public Bioscoopvertoning(
            Film film,
            DateTime begintijd,
            Filmkwaliteit filmkwaliteit,
            Zaal zaal)

            : base(film.Titel, film.Jaar, film.Speelduur, film.Taal, film.Leeftijdscategorie, film.Genres)
        {
            Begintijd = begintijd;
            BioscoopZaal = zaal;
            Film_kwaliteit = filmkwaliteit;
            Bestellingen = new List<Bestelling>();
        }

        /// <summary>
        /// Voegt bestelling toe aan een bioscoopvertoning
        /// </summary>
        /// <param name="bestelling"></param>
        /// <returns></returns>
        public void VoegBestellingToe(Bestelling bestelling)
        {
            if (bestelling == null)
            {
                throw new ArgumentNullException();
            }

            Bestellingen.Add(bestelling);
        }

        public override string ToString()
        {
            return Titel + " - " + Begintijd.ToShortDateString() + " - " + Begintijd.ToShortTimeString() + " - Zaal:" + BioscoopZaal.Zaalnummer + " - " + Film_kwaliteit.ToString();
        }

        public enum Filmkwaliteit
        {
            _2D,
            _3D, 
            _Imax_2D,
            _Imax_3D
        };
    }
}

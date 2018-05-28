using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Films
{
    public class Bioscoopvertoning : Film
    {
        public DateTime Begintijd { get; private set; }
        public DateTime Eindtijd { get {return Begintijd.AddMinutes(base.Speelduur);} }
        public Filmkwaliteit Film_kwaliteit { get; private set; }
        public Zaal BioscoopZaal { get; private set; }
        public List<Bestelling> Bestellingen { get; private set; }

        public Bioscoopvertoning(string titel, int jaar, int speelduur, string taal, int leeftijdscategorie, List<Genre> lijstGenres, DateTime begintijd, Filmkwaliteit filmkwaliteit, Zaal zaal) : base(titel, jaar, speelduur, taal, leeftijdscategorie, lijstGenres)
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
            return Titel + " - " + Jaar + " - " + Speelduur + " minuten - " + Taal + " - " + Leeftijdscategorie + " - " + Genres.ToString() + " - " + Begintijd + " - " + Eindtijd + " - " + Film_kwaliteit.ToString() + " - " + BioscoopZaal;
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

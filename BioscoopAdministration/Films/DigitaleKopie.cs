using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Films
{
    public class DigitaleKopie : Film
    {
        public int Toegangscode { get; private set; }
        public List<Uitlening> Uitleningen { get; private set; }

        public DigitaleKopie(string titel, int jaar, int speelduur, string taal, int leeftijdscategorie, List<Genre> lijstGenres, int toegangscode) : base(titel, jaar, speelduur, taal, leeftijdscategorie, lijstGenres)
        {
            Toegangscode = toegangscode;
            Uitleningen = new List<Uitlening>();
        }

        /// <summary>
        /// Voegt uitlening toe aan een digitale kopie
        /// </summary>
        /// <param name="uitlening"></param>
        /// <returns></returns>
        public bool VoegUitleningToe(Uitlening uitlening)
        {
            if (uitlening == null) return false;

            Uitleningen.Add(uitlening);
            return true;
        }

        public override string ToString()
        {
            return Titel + " - " + Jaar + " - " + Speelduur + " - " + Taal + " - " + Leeftijdscategorie + " - " + Genres.ToString() + " - " + Toegangscode;
        }
    }
}

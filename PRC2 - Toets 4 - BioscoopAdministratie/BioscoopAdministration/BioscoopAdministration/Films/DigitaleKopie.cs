using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BioscoopAdministration.Producten;

namespace BioscoopAdministration
{
    public class DigitaleKopie : Film, IInfo
    {
        public int Toegangscode { get; private set; }
        public List<Uitlening> Uitleningen { get; private set; }
        public double PrijsPerDag { get; private set; }
        public string InfoString
        {
            get
            {
                return "Digitalekopie van " + Titel + Environment.NewLine +
                        "Prijs per dag: €" + PrijsPerDag;
            }
        }

        public string InfoLijstNaam
        {
            get
            {
                return "Uitleningen";
            }
        }
        public List<object> InfoLijst
        {
            get
            {
                return Uitleningen.Cast<object>().ToList();
            }
        }

        public DigitaleKopie(
            string titel, 
            int jaar, 
            int speelduur, 
            string taal, 
            int leeftijdscategorie, 
            List<Genre> lijstGenres, 
            int toegangscode,
            double prijsPerDag)
            
            : base(titel, jaar, speelduur, taal, leeftijdscategorie, lijstGenres)
        {
            Toegangscode = toegangscode;
            Uitleningen = new List<Uitlening>();
            PrijsPerDag = prijsPerDag;
        }

        public DigitaleKopie(
            Film film, 
            int toegangscode,
            double prijsPerDag)
            : base(film.Titel, film.Jaar, film.Speelduur, film.Taal, film.Leeftijdscategorie, film.Genres)
        {
            Toegangscode = toegangscode;
            Uitleningen = new List<Uitlening>();
            PrijsPerDag = prijsPerDag;
        }

        /// <summary>
        /// Voegt uitlening toe aan een digitale kopie
        /// </summary>
        /// <param name="uitlening"></param>
        /// <returns></returns>
        public void VoegUitleningToe(Uitlening uitlening)
        {
            if (uitlening == null) throw new ArgumentNullException("uitlening", "uitlening mag niet null zijn");

            Uitleningen.Add(uitlening);
        }

        public override string ToString()
        {
            return Titel + " - " + Jaar + " - " + Speelduur + " minuten - " + Leeftijdscategorie + "+";
        }
    }
}

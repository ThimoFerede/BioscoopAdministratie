using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BioscoopAdministration.Producten;

namespace BioscoopAdministration.Producten
{
    [Serializable]
    public class Uitlening : IPrice,IInfo
    {
        public DateTime Startdatum { get; private set; }
        public DateTime Einddatum { get; private set; }
        public Lid Lid { get; private set; }
        public DigitaleKopie DigitaleKopie { get; private set; }
        public string InfoString
        {
            get
            {
                return "Uitlening van: " + Lid.Naam + Environment.NewLine + DigitaleKopie.InfoString;
            }
        }

        public string InfoLijstNaam
        {
            get
            {
                return "Digitalekopie";
            }
        }
        public List<object> InfoLijst
        {
            get
            {
                return new List<object>() { DigitaleKopie };
            }
        }

        public double Price
        {
            get { return DigitaleKopie.PrijsPerDag * Einddatum.Subtract(Startdatum).Days; }
        }
        /// <summary>
        /// Maak een uitlening aan
        /// De uitlening wordt automatisch aan het lid toegevoegd
        /// </summary>
        /// <param name="startdatum"></param>
        /// <param name="einddatum"></param>
        /// <param name="lid"></param>
        public Uitlening(DateTime startdatum, DateTime einddatum, DigitaleKopie digitaleKopie, Lid lid)
        {
            Startdatum = startdatum;
            Einddatum = einddatum;
            Lid = lid ?? throw new ArgumentNullException();
            DigitaleKopie = digitaleKopie ?? throw new ArgumentNullException();
            Lid.VoegUitleningToe(this);
            DigitaleKopie.VoegUitleningToe(this);
        }

        public override string ToString()
        {
            return "Uitlening " + DigitaleKopie.Titel + " voor " + Lid.Naam;
        }
    }
}

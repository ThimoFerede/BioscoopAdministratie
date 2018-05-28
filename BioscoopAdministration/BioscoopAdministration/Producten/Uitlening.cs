using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BioscoopAdministration.Producten;

namespace BioscoopAdministration.Producten
{
    public class Uitlening : IPrice
    {
        public DateTime Startdatum { get; private set; }
        public DateTime Einddatum { get; private set; }
        public Lid Lid { get; private set; }
        public DigitaleKopie DigitaleKopie { get; private set; }

        public double Price
        {
            get { return 0; }
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
    }
}

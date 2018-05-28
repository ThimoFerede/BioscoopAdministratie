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
        public Lid lid { get; private set; }

        public int Price
        {
            get { return 0; }
        }

        public Uitlening(DateTime startdatum, DateTime einddatum, Lid lid)
        {
            Startdatum = startdatum;
            Einddatum = einddatum;
            this.lid = lid;
        }
    }
}

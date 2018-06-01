using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioscoopAdministration
{
    interface IInfo
    {
        string InfoString { get; }
        string InfoLijstNaam { get; }
        List<object> InfoLijst { get; }
    }
}

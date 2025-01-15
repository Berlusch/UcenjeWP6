using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17KlasaObjekt.ZavrsniRad
{
    public class Upit : Entitet
    {
        public Pas Pas { get; set; } = new Pas();
        public Udomitelj Udomitelj { get; set; } = new Udomitelj();
        public DateOnly DatumUpita { get; set; }
        public string StatusUpita { get; set; } = "";
        public Pas[]? Psi { get; set; }
        public Udomitelj[]? Udomitelji { get; set; }
    }
}

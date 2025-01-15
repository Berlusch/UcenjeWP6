using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17KlasaObjekt.ZavrsniRad
{
    public class Pas
    {
        public int Sifra { get; set; }
        public char BrojCipa { get; set; }
        public string Ime { get; set; } = "";
        public DateOnly DatumRodjenja { get; set; }
        public string Spol { get; set; } = "";
        public string Velicina { get; set; } = "";
        public string Boja { get; set; } = "";
        public bool Kastracija { get; set; }
        public Status Status { get; set; } = new Status();
    }
}

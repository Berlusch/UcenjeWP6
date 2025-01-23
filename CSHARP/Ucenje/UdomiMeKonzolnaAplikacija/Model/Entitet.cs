using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.UdomiMeKonzolnaAplikacija.Model
{

    public class Entitet
    {
        public int Sifra { get; set; }

        public override string ToString()
        {
            return Sifra.ToString();
        }
    }
}


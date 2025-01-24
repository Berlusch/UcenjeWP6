using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.UdomiMeKonzolnaAplikacija.Model
{
    public class Udomitelj : Entitet
    {
        public string Ime { get; set; } = "";
        public string Prezime { get; set; } = "";
        public string Adresa { get; set; } = "";
        public string? Telefon { get; set; }
        public string Email { get; set; } = "";
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.UdomiMeKonzolnaAplikacija.Model
{
    public class Udomitelj : Entitet, IComparable<Udomitelj>
    {
        public string Ime { get; set; } = "";
        public string Prezime { get; set; } = "";
        public string Adresa { get; set; } = "";
        public string? Telefon { get; set; }
        public string Email { get; set; } = "";
    
        public int CompareTo(Udomitelj? other)
        {
            return Prezime.CompareTo(other.Prezime);
        }
        public override string ToString()
        {
            return $"{Ime} {Prezime}, {Adresa}, Tel: {Telefon}, Email: {Email}";
        }
    }
}

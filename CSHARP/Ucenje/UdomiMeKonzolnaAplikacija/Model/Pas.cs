using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.UdomiMeKonzolnaAplikacija.Model
{
    public class Pas : Entitet
    {
        public string Ime { get; set; } = "";
        public string BrojCipa { get; set; } = "";
        public string Pasmina { get; set; } = "";
        public DateTime DatumRodjenja { get; set; }
        public enum Spol { Ž, M }
        public Spol SpolVrsta { get; set; }
        public string Velicina { get; set; } = "";
        public string Boja { get; set; } = "";
        public string MojaPrica { get; set; } = "";
        public bool Kastracija { get; set; }

        public Status StatusOpis { get; set; } = new Status();

        public DateTime? DatumPromjene { get; set; }


        public string ProvjeriKastraciju()
        {
            return Kastracija ? "Obavljena" : "Nije obavljena";
        }

        public void MojaPricaUvod()
        {
            Console.WriteLine("Pozdrav! Zovem se {0}, rođen/a sam {1}. Uredno sam čipiran/a i cijepljen/a, a moj broj čipa je {2}. Udomi me!", Ime, DatumRodjenja, BrojCipa);
            Console.WriteLine();
            Console.WriteLine(MojaPrica);
        }

        public void DetaljiPsa()
        {
            Console.WriteLine(Ime, SpolVrsta);
            Console.WriteLine(BrojCipa);
            Console.WriteLine(Pasmina);
            Console.WriteLine(DatumRodjenja);
            Console.WriteLine(Velicina, Boja);
            Console.WriteLine(ProvjeriKastraciju());
            Console.WriteLine(StatusOpis);

        }


    }
}

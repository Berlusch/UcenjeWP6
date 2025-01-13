using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17KlasaObjekt.edunova
{
    public class Grupa
    {
        public int Sifra { get; set; }
        public string Naziv { get; set; } = "";
        public int VelicinaGrupe { get; set; }
        public string? Predavac { get; set; }
        public Smjer Smjer { get; set; } = new Smjer();
        public Polaznik[]? Polaznici { get; set; }

        public void DetaljiGrupe()
        {
            Console.WriteLine(Naziv);
            Console.WriteLine(Smjer.Naziv);
            foreach (Polaznik p in Polaznici?? [])
            {
                Console.WriteLine(p.ImePrezime());
                //Console.WriteLine("{0} {1}", p.Ime, p.Prezime); ovoj liniji nije ovdje mjesto
            }
        }
    }
}

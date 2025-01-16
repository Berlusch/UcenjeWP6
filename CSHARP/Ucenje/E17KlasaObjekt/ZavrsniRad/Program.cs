using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using Ucenje.E18NasljedivanjePolimorfizam;

namespace Ucenje.E17KlasaObjekt.ZavrsniRad
{
    public class Program
    {
        public Program()
        {
            Pas pas = new();
            pas.Sifra = 1;
            pas.Ime = "Bergo";
            pas.Boja = "Smeđa";
            pas.Velicina = "Veliki";
            
            

            Console.WriteLine();



            osoba = new Osoba()
            {
                Sifra = 2,
                Ime = "Karlo",
                Prezime = "Lik"

            }
        
    }
}

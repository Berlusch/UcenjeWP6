using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E18NasljedivanjePolimorfizam
{
    public class Program
    {
        //konstruktor poziva se s ključnom riječju new (u Program.cs u namespace Ucenje)
        public Program() 
        {
            Console.WriteLine("E18");
            var smjer = new Smjer() { Sifra=1, Naziv="Web programiranje"};

            Console.WriteLine(smjer);//kada se ispisuje cijeli objekt izvodi se metoda toString na klasama od dolje prema gore (zadnja je Object)


            var osoba = new Osoba() { Sifra = 1, Ime = "Pero", Prezime = "Perić" };
            Console.WriteLine(osoba);


            //string je immutable
            string s1 = "AA";
            Console.WriteLine(s1.GetHashCode()); //hashcode reprezentant memorijske lokacije

            s1 = "BB";

            Console.WriteLine(s1.GetHashCode());

            //dosadašnja praksa spajanja stringova s + nije dobra

            //dobra praksa je koristiti string builder

            var sb=new StringBuilder();

            sb.Append("AA");

            Console.WriteLine(sb.GetHashCode());

            sb.Clear().Append("BB");
            Console.WriteLine(sb.GetHashCode());

            Smjer smjer1 = new Smjer() { Naziv = "Web programiranje" };
            Smjer smjer2 = new Smjer() { Naziv = "Web programiranje" };

            Console.WriteLine(smjer1.GetHashCode());
            Console.WriteLine(smjer2.GetHashCode());

            Console.WriteLine(smjer.Equals(smjer2));




        }

        
    }
}

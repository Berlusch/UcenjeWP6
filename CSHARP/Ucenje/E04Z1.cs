using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    //Program od korisnika traži unos broj godina koje ima korisnik
    //Program ispisuje da li je korisnik punoljetna osoba ili ne

    //dodatno: ako je unos ispod nula godine ili iznad 112 godina ispisati GREŠKA
    internal class E04Z1
    {
        public static void Izvedi()
        {
            Console.Write("Koliko imaš godina?");
            int godine = int.Parse(Console.ReadLine());

            if (godine <= 18)
            {
                Console.WriteLine("Vi ste maloljetna osoba");
            }
            else
            {
                Console.WriteLine("Vi ste punoljetna osoba");
            }

            if (godine > 112 && godine < 0)
            {
            Console.WriteLine("Greška");
            }
        }
    }

}

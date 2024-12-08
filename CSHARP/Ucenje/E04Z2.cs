using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{

    // Program od korisnika traži unos cijelog broja
    // Program ispisuje da li je uneseni broj paran ili ne


    internal class E04Z2
    {
        public static void Izvedi()
        {
            //Console.WriteLine("E04");
            Console.WriteLine("Unesi cijeli broj:");
            int broj = int.Parse(Console.ReadLine());
            if(broj%2 == 0)
            {
                Console.WriteLine("Paran.");
            }
            else
            {
                Console.WriteLine("Neparan.");
            }

            // sada dajte rješenje s inline if

        }
    }
}

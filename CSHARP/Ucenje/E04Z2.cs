using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{

    //program od korisnika traži unos cijelog broja
    //program ispisuje da li je uneseni broj paran ili ne
    internal class E04Z2
    {

        public static void Izvedi()
        {
            Console.Write("Unesi cijeli broj: ");
            int broj = int.Parse(Console.ReadLine());

            if (broj % 2 == 0)
            {
                Console.WriteLine("Broj je paran");
            }
            else
            {
                Console.WriteLine("Broj je neparan");
            }

            //rješenje s inline if
          
            Console.WriteLine(broj % 2 == 0 ? "Broj je paran" : "Broj je neparan");
      


        }
    }
}

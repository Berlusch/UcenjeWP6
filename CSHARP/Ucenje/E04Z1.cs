using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
<<<<<<< HEAD

    // Program od korisnika traži unos broj godina koje ima korisnik
    // Program ispisuje da li je korisnik punoljetna osoba ili ne


    // dodatno: ako je unos ispod nula godine ili iznad 112 godina ipisasti GREŠKA
=======
    //Program od korisnika traži unos broj godina koje ima korisnik
    //Program ispisuje da li je korisnik punoljetna osoba ili ne

    //dodatno: ako je unos ispod nula godine ili iznad 112 godina ispisati GREŠKA
>>>>>>> 6b5bbcef1a2b67d556a568dff19e946cca422870
    internal class E04Z1
    {
        public static void Izvedi()
        {
<<<<<<< HEAD

            //Console.WriteLine("Z1");
            Console.Write("Unesite godine: ");
            int godine = int.Parse(Console.ReadLine());

            if (godine >= 18)
            {
                if (godine > 112)
                    Console.WriteLine("Greška!");
                else
                    Console.WriteLine("Punoljetan");
            }


            else
            {
                if (godine < 0)
                    Console.WriteLine("Greška!");
            else
                Console.WriteLine("Maloljetan");

            }


        }
    }
=======
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

>>>>>>> 6b5bbcef1a2b67d556a568dff19e946cca422870
}

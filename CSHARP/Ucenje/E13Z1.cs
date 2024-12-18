using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E13Z1
    {

        public static void Izvedi()
        {
            int broj = E12Metode.UcitajCijeliBroj("Unesi broj: ");
            while (broj < 0 || broj > 10)
            {
                Console.WriteLine("Broj mora biti između 1 i 9");
                broj = E12Metode.UcitajCijeliBroj("Daj mi broj ");
            }
            Console.WriteLine("Rez je {0}", Faktorijel(broj));


        }
        private static int Faktorijel(int b)
        {
            if (b == 1)
            {
                return 1;
            }
            return b * Faktorijel(b - 1);
        }
        //program od korisnika unosi cijeli broj koji mora biti veći od 0 i manji od 10
        //program ispisuje faktorijel od unesenog broja (npr. 2*3*4*5*6 za uneseni broj 6)








    }
}

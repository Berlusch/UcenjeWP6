using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E01UlazIzlaz
    {

        public static void Izvedi()
        {
            // Ovo je izlaz
            Console.Write("Unesi svoje ime: ");


            // Ulaz podataka u program
            string Ime = Console.ReadLine();

            Console.WriteLine("Unijeli ste " + Ime);

            // formatirani način ispisa
            Console.WriteLine("Unijeli ste {0}. Bravo!", Ime);

        }


    }
}

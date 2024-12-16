using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{

    // Program od korisnika unosi cijeli broj 
    // Koristeći while petlju program ispisuje 
    // zbroj svih parnih brojeva od 1 do unesenog broja (skupa s njim)
    // unos 10 ispis 30
    // unos 12 ispis 42

    internal class E09Z1
    {

        public static void Izvedi()
        {
            //Console.WriteLine("Z1");

            Console.Write("Unesi jedan cijeli broj: ");
            int broj = int.Parse(Console.ReadLine());
            int suma = 0;
            int i = 2;

            while (i <= broj)
            {
                suma += i;
                i += 2; //kako bi broj bio uvijek samo paran
            }
            Console.WriteLine("Zbroj svih parnih brojeva od 1 do {0} je {1}", broj, suma);

            //DRUGI NAČIN

            if (i % 2 == 0)
            {
                while (i <= broj)
                {
                    suma += i;
                }
                Console.WriteLine("Zbroj svih parnih brojeva od 1 do {0} je {1}", broj, suma);
            }

        }



    }
}

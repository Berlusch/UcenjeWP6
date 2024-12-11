using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E07Z1
    {
        // Program od korisnika unosi cijeli broj

        //  Ako je uneseni broj paran, program ispisuje zbroj svih brojeva od 1 do unesenog
        // inače program ispisuje svaki neparni broj od 1 do unesenog
        public static void Izvedi()
        {
            Console.Write("Unesi cijeli broj: ");
            int broj = int.Parse(Console.ReadLine());


            if (broj % 2 == 0)
            {
                int zbroj = 0;
                for (int i = 0; i <= broj; i++)
                {
                    zbroj += i;
                }

            Console.WriteLine(zbroj);
            }

            else
            {
                for(int i=1; i <= broj; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }

            }


        }






    }
}

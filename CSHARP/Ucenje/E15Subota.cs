using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E15Subota
    {

        public static void Izvedi()
        {
            PrimjerTryCatch();

        }

        private static void PrimjerTryCatch()
        {

            try
            {
                int.Parse("Osijek");
            }
            catch
            {
                Console.WriteLine("Žao nam je zbog greške");

            }

            //osigurajte unos logičke vrijednosti
            bool vrijednost = false;//može i bez, jer je default false

            Console.Write("Jesi li zaposlen/a? (upiši DA ili bilo što za NE: ");
            if(Console.ReadLine().Trim().ToUpper() == "DA")
            {
                vrijednost = true;
            }
            Console.WriteLine(vrijednost);
            Console.WriteLine(E12Metode.UcitajBool("Jesi li zaposlen/a? (upiši DA ili bilo što za NE: )", "DA"));
        }
            

                            





            
        }
}


using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{

    // Program od korisnika traži unos dva cijela broja
    // Program ispisuje manji

    // isti zadatak ali za tri unesena broja ispisati najmanji

    internal class E04Z3
    {
        public static void Izvedi()
        {

            //dva unesena broja

            /*Console.Write("Unesi jedan cijeli broj: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Unesi drugi cijeli broj: ");
            int b = int.Parse(Console.ReadLine());

            if (a < b)
            {
                Console.WriteLine("Manji broj je {0}", a);
            }

            else
            {
                Console.WriteLine("Manji broj je {0}", b);
            }
            */

            //tri unesena broja

            Console.Write("Unesi jedan cijeli broj: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Unesi drugi cijeli broj: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Unesi jedan cijeli broj: ");
            int c = int.Parse(Console.ReadLine());

            if (a < b && a < c)
            {
                Console.WriteLine("Najmanji broj je {0}", a);
            }
            if (b < a && b < c)
            {
                Console.WriteLine("Najmanji broj je {0}", b);
            }
            if (c < a && c < b)
            {
                Console.WriteLine("Najmanji broj je {0}", c);
            }
            
        }
    }
}
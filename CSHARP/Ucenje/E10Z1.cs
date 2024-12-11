using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{

    //za dani izraz bez razmaka provjeriti je li palindrom
    internal class E10Z1
    {
        public static void Izvedi()
        {
            Console.Write("Unesi jedan izraz: ");
            string izraz = Console.ReadLine();
            Console.WriteLine(izraz);

            if (izraz.Length % 2 == 0)
            {
                //paran broj znakova
                Console.WriteLine("parno");
                bool palindrom = true;
                for (int i = 0; i < izraz.Length / 2; i++)
                {
                    {
                        if (izraz[i] != izraz[izraz.Length - 1 - i])
                        {
                            palindrom = false;
                            break;
                        }

                    }
                    Console.WriteLine(palindrom ? "DA" : "NE");

                    //else
                    //neparan broj znakova



                }
                //kisik
                //abba
                //anavolimilovana
                //amenetuniminutenema
            }
        }
    }
}

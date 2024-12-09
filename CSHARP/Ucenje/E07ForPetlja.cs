using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E07ForPetlja
    {

        public static void Izvedi()
        {

            //Console.WriteLine("E07");

            //10 puta jedno ispod drugog ispišite Osijek

            /*Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            Console.WriteLine("Osijek");
            */

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}. Osijek iz petlje", i);
            }

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine("{0}. Unazad", i);
            }

            //ugniježđena petlja

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write("\t{0}", i * j);
                }
                Console.WriteLine();
            }

            //formatirati brojeve u tablici prema desno

            //koliko je zbroj prvih 100 brojeva?
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += i;//postojećoj sumi dodajemo vrijednost i

            }
            Console.WriteLine(sum);
            int x = 100;
            Console.WriteLine((x + 1) * x / 2);

            //Ispiši sve parne brojeve od 1 do 20

            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                    Console.Write("{0},", i);

            }

            //maknuti zadnji zarez


            Console.WriteLine();
            int idiod = 12;
            int idido = 34;

            for (int i = idiod; i <= idido; i++)
            {
                Console.WriteLine(i);

            }

            int[] brojevi = { 1, 2, 3, 4, 5, 6 };

            //ispisati sve brojeve iz niza
            for (int i = 0; i < brojevi.Length; i++)
            {
                Console.WriteLine(brojevi[i]);
            }

            int[,] tablica =
            {
                {1, 2, 3 },
                {4, 5, 6 },
                {7, 8, 9 }
            };

            for (int i = 0; i < tablica.GetLength(0); i++)//x
            {
                for (int j = 0; j < tablica.GetLength(1); j++)//y
                {
                    Console.Write(tablica[i, j] + " ");
                }
                Console.WriteLine();
            }

            //petlju se može preskočiti (nastaviti) i nasilno prekinuti

            for (int i = 0; i < 10; i++)
            {
                if (i == 3)
                {
                    continue;
                }

                if (i == 7)
                {
                    break;
                }

                Console.WriteLine(i);
            }

            //saznati kako prekinuti ugniježđenu petlju (iz najdublje vanjsku)

            //----------------beskonačna petlja

            //kako postići beskonačnu petlju - ovo nije!

            for(int i=0;i>=0; i++)
            { 
                Console.WriteLine(i);
                break;
            }       
            //beskonačna
            for(; ; )
            {
                Console.WriteLine(new Random().NextInt64() + "" + new Random().NextInt64() +""+ new Random().NextInt64());
                Thread.Sleep(300);
            }


        }



    }
}


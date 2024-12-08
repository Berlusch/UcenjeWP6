using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E06Nizovi
    {

        public static void Izvedi()
        {
            //Console.WriteLine("E06");

            // motivacija: treba nam 12 varijabli za pohranu 12 vrijednosti prosječnih temperatura u mjeseca
            int sijecanj, veljaca, ozujak; // nije dobra praksa


            // end. Arrays
            // još na HR poja polja
            // uglata zagrada Alt Gr + F, zatvoreno je Alt Gr + G
            // jednodimenzionalni niz
            int[] temp = new int[12]; // problem nizova je što moraš unaprijed znati broj elemenata

            // 1. element iza je na indeksu 0
            temp[0] = 2; //siječanj
            // postavio i na sve ostalo
            temp[11] = 4; //prosinac

            Console.WriteLine(temp);
            Console.WriteLine(string.Join(",",temp));


            // dvodimenzionalni niz
            int[,] tablica =
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
            };

            // kako bi ispisali broj 6

            Console.WriteLine(tablica[1,2]);

            // trodimenzionalni niz
            int[,,] kocka = { };


            // tesaarect - 4 dimenzije

            int[,,,] tesaarect = { };

            // multiverse
            int[,,,,,,] multiverse = { };


        }

    }
}

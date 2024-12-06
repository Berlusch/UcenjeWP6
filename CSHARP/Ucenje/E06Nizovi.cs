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
            //end.Arrays
            //još na hr pojam POLJE
            //uglata zagrada altgr fg
            //jednodimenzionalni niz
            int[] temp = new int[12]; //treba unaprijed znati broj elemenata

            //prvi element niza je na indeksu 0
            temp[0] = 2;
            //i na ostalo
            temp[11] = 4;

            Console.WriteLine(temp);
            Console.WriteLine(string.Join(",", temp));


            //dvodimenzionalni niz
            int[,] tablica =
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
            };

            //kako bi ispisali broj 6
            Console.WriteLine(tablica[1,2]);

            //tesaarect - 4 dimenzije

            int[,,,] tesaarect = { };

            //multiverse
            int[,,,,,,] multiverse = { };

        }
    }
}

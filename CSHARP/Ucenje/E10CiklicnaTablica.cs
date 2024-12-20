using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E10CiklicnaTablica
    {

        public static void Izvedi()
        {
            int redova = 5;
            int kolona = 5;


            //int redova = E12Metode.UcitajCijeliBroj("Unesi broj redova: ");
            //int kolona = E12Metode.UcitajCijeliBroj("Unesi broj kolona: ");

            int[,] tablica = new int[redova, kolona];

            int brojac = 1;
            //dolje desno prema lijevo
            for (int i = kolona - 1; i >= 0; i--)
            {
                tablica[redova - 1, i] = brojac++;
            }

            //IspisiTablicu(tablica);

            //dolje lijevo prema gore
            for (int i = redova - 2; i <= 0; i--)
            {
                tablica[i, kolona - 5] = brojac++;
            }

            IspisiTablicu(tablica);
        }
        private static void IspisiTablicu(int[,] tablica)
        {
            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    Console.Write(tablica[i, j] + " ");
                }
                Console.WriteLine();

            }
            //Console.WriteLine("*************************");
        }
    }
}

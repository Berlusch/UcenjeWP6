using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E10CiklicnaTablica
    {

        public static void Izvedi()
        {
            int redova = E12Metode.UcitajCijeliBroj("Unesi broj redova: ");
            int kolona = E12Metode.UcitajCijeliBroj("Unesi broj kolona: ");

            int cilj = redova * kolona;
            int brojac = 1;
            int maxLijevo = 0;
            int maxGore = 0;
            int maxDesno = kolona - 1;
            int maxDolje = redova - 1;

            int[,] tablica = new int[redova, kolona];


            while (brojac <= cilj)
            {
                // Dolje desno prema lijevo------------------------------------------------------
                for (int i = maxDesno; i >= maxLijevo; i--)
                {
                    tablica[maxDolje, i] = brojac++;
                }
                maxDolje--;
                if (brojac == cilj) break;

                // Lijevo dolje prema gore-------------------------------------------------------------
                for (int i = maxDolje; i >= maxGore; i--)
                {
                    tablica[i, maxLijevo] = brojac++;
                }
                maxLijevo++;
                if (brojac == cilj) break;

                // Gore lijevo prema desno-----------------------------------------------------------
                for (int i = maxLijevo; i <= maxDesno; i++)
                {
                    tablica[maxGore, i] = brojac++;
                }
                maxGore++;
                if (brojac == cilj) break;

                // Desno gore prema dolje----------------------------------------------------------------
                for (int i = maxGore; i <= maxDolje; i++)
                {
                    tablica[i, maxDesno] = brojac++;
                }
                maxDesno--;
                if (brojac == cilj) break;
            }

            //Ispis tablice-----------------------------------------------------------------------
            IspisiTablicu(tablica);



        }
        private static void IspisiTablicu(int[,] tablica)
        {
            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {

                    {
                        Console.Write("{0,4}", tablica[i, j] + "  ");

                    }

                }
                Console.WriteLine();
                Console.WriteLine();

            }

        }
    }
}
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
            int max = -1;
            int[,] tablica = new int[redova, kolona];


            while(brojac<=cilj)
            {
                redova = redova - 1;
                kolona = kolona - 1;
                max++;
                
                
                for (int i = kolona; i >= max; i--)
                {
                    tablica[redova, i] = brojac++;

                }
                if (brojac == cilj)
                {

                    break;
                }
                //Console.WriteLine("Prva");
                //IspisiTablicu(tablica);


                //dolje lijevo prema gore

                for (int i = redova - 1; i >= max; i--)
                {
                    tablica[i, max] = brojac++;

                }
                if (brojac == cilj)
                {

                    break;
                }
                //Console.WriteLine("Druga");
                //IspisiTablicu(tablica);

                //gore lijevo prema desno

                for (int i = max + 1; i <= kolona; i++)
                {
                    tablica[max, i] = brojac++;
                }
                if (brojac == cilj)
                {

                    break;
                }
                
                
                //Console.WriteLine("Treća");
                //IspisiTablicu(tablica);
                //gore desno prema dolje

                for (int i = max+1; i <= redova-(max+1); i++)
                {
                    tablica[i, kolona] = brojac++;
                }
                if (brojac == cilj)
                {
                    break;
                }
                
                //Console.WriteLine("Četvrta");
                //IspisiTablicu(tablica);

            }
            //Console.WriteLine("Zadnja");
            IspisiTablicu(tablica);









            ///////PRVA VERZIJA 5X5 *******************************************


            /*//dolje desno prema lijevo
            for (int i = kolona - 1; i >= 0; i--)
            {
                tablica[redova - 1, i] = brojac++;

            }

            //dolje lijevo prema gore

            for (int i = redova - 2; i >= 0; i--)
            {
                tablica[i, 0] = brojac++;
            }

            //gore lijevo prema desno

            for (int i = kolona - 4; i <= kolona - 1; i++)
            {
                tablica[0, i] = brojac++;
            }

            //gore desno prema dolje

            for (int i = redova - 4; i <= redova - 2; i++)
            {
                tablica[i, kolona - 1] = brojac++;
            }

            //

            for (int i = kolona - 2; i >= 1; i--)
            {
                tablica[redova - (redova - 3), i] = brojac++;
            }

            //

            for (int i = redova - 3; i >= 1; i--)
            {
                tablica[i, kolona - 4] = brojac++;
            }

            //

            for (int i = kolona - 3; i <= 3; i++)
            {
                tablica[redova - 4, i] = brojac++;
            }

            //

            for (int i = kolona - 2; i >= 2; i--)
            {
                tablica[redova - 3, i] = brojac++;
            }

            */
            //IspisiTablicu(tablica);











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
            //Console.WriteLine("*************************");
        }
    }
}



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
            string razmak = "";


            //int redova = E12Metode.UcitajCijeliBroj("Unesi broj redova: ");
            //int kolona = E12Metode.UcitajCijeliBroj("Unesi broj kolona: ");

            int[,] tablica = new int[redova, kolona];

            int brojac = 1;
            //dolje desno prema lijevo
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

            
            IspisiTablicu(tablica);









        }
        private static void IspisiTablicu(int[,] tablica)
        {
            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {

                    {
                        Console.Write(tablica[i, j] + "  ");

                    }


                }
                Console.WriteLine();
                Console.WriteLine();

            }
            //Console.WriteLine("*************************");
        }
    }
}


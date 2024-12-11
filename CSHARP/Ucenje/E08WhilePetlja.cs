using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E08WhilePetlja
    {

        public static void Izvedi()
        {
            //Console.WriteLine("E08");


            int brojDo = 10;//ovo unosi korisnik
            for (int i = 0; i < brojDo; i++)
            {
                Console.WriteLine(i);
            }

            //while radi s bool tipom podatka
            //beskonačna petlja

            while (true)
            {
                Console.WriteLine("Osijek");
                break;

            }
            //switch radi s brojevaima, char i string

            //najčešći način while petlje

            int broj = 0, t = 2;
            while (broj < 10 && t==2)
            {
                Console.WriteLine(++broj);
            }

            //u while se ne mora ući
            broj = 10;
            while (broj < 10)
            {

                Console.WriteLine(++broj);
            }

            //zadatak s while petljom zbrojiti prvih 100 brojeva

            int suma = 0;
            broj = 1;
            while (broj <= 100)
            {
                suma += broj++;
                Console.WriteLine(suma);
            }
        }
    }
}

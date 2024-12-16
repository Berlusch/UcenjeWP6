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

            // pojam ulaska u petlju
            // u for petlju se ne mora ući


            int brojDo = 0; //ovo unosi korisnik

            for(int i = 0; i < brojDo; i++)
            {
                Console.WriteLine(i);
            }


            // while radi s bool tipom podatka
            // beskonačna petlja
            while (true)
            {
                Console.WriteLine("Osijek");
                break;
            }

            // if radi s bool tipom podatke
            // switch rad s brojevima, char i string
            // while radi s bool tipom podatka


            //najčešći način while

            int broj = 0, t=2;


            while (broj < 10 && t==2)
            {
                Console.WriteLine(++broj);
               
            }


            // u while se ne mora ući
            broj = 10;
            while(broj < 10)
            {
                Console.WriteLine(++broj);
            }

            // ZAD s while petljom zbrojiti prvih 100 brojeva

            int suma = 0;
            for(int j = 1; j <= 100; j++)
            {
                suma += j;
            }
            Console.WriteLine(suma);

            suma = 0;
            broj = 1;
            while (broj <= 100)
            {
                //suma += broj++;
                suma = suma + broj;
                broj = broj + 1;
            }
            Console.WriteLine(suma);

        }

    }
}

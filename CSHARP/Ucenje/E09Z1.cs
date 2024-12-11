using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E09Z1

    {
        //program od korisnika unosi cijeli broj, koristeći while petlju ispisuje
        //zbroj svih parnih brojeva od 1 do unesenog broja (skupa s njim)
        //unos 10 ispis 30
        //unos 12 ispis 42
        public static void Izvedi()
        {
            Console.Write("Unesi cijeli broj: ");
                int broj = int.Parse(Console.ReadLine());

            Console.WriteLine(broj);

            int i = 0, suma = 0;
            while(i<=broj)
            {
                //Console.WriteLine("U petlji sam");
                if (++i % 2 == 0)
                {
                    suma+= i;
                }
                
            }
            Console.WriteLine(suma);
        }





    }


}



        
        

        
    


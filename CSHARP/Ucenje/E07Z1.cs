using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E07Z1

    //program od korisnika unosi cijeli broj

    //ako je uneseni broj paran, program ispisuje zbroj svih brojeva od 1 do unesenog
    //inače program ispisuje svaki neparni broj od 1 do unesenog
    {
        public static void Izvedi()
        {
            Console.Write("Unesi jedan cijeli broj: ");
            int broj = int.Parse(Console.ReadLine());

            if (broj % 2 == 0)
            {
                int sum = 0;
                for (int i = 1; i <= broj; i++)
                {
                    sum += i;
                }
                Console.WriteLine(sum);


            }
            else
            {
                int sum = 0;
                for (int i = 1; i <= broj; i++)
                {
                    if (i % 2 == 1)
                    {
                        {
                            sum += i;
                        }
                        Console.WriteLine(i);
                    }
                }





            }



        }
    }
}


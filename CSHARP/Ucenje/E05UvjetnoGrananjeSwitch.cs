using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E05UvjetnoGrananjeSwitch
    {

        public static void Izvedi()
        {
            //Console.WriteLine("E05");

            int i = 2;

            switch (i)
            {
                case 1:
                    Console.WriteLine("Nedovoljan");
                    break;
                case 2:
                    Console.WriteLine("Dovoljan");
                    break;
                default:
                    Console.WriteLine("Ostalo");
                    break;
            }

            char znak = '@';
            Console.WriteLine(znak);
            Console.WriteLine((int)znak);

        }
    }
}

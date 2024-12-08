using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

            // switch radi s int, string, char i drugi https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/statements#1383-the-switch-statement


            char znak = '@';
            Console.WriteLine(znak);
            Console.WriteLine((int)znak);
            
            
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{

    /*
        *  KORISTEĆI IF
        * 
       Program učitava od korisnika ime grada.U ovisnosti o imenu grada ispisuje regiju prema sljedećim pravilima:

      Osijek -> Slavonija
      Zadar -> Dalmacija
      Čakovec -> Međimurje
      Pula -> Istra
      Za ostale unose program ispisuje: Ne znam koja je to regija.
       */

    // dodatno: Odraditi istu logiku s switch
    internal class E04Z4
    {
        public static void Izvedi()
        {
            Console.Write("Unesi ime grada: ");
            string grad = Console.ReadLine();

            /*
                        if (grad == "Osijek")
                        {
                            Console.WriteLine("Regija Slavonija");
                        }
                        if (grad == "Zadar")
                        {
                            Console.WriteLine("Regija Dalmacija");
                        }

                        if (grad == "Čakovec")
                        {
                            Console.WriteLine("Regija Međimurje");
                        }

                        if (grad == "Pula")
                        {
                            Console.WriteLine("Regija Istra");
                        }

                        if (grad != "Osijek" && grad != "Zadar" && grad != "Čakovec" && grad != "Pula")

                            Console.WriteLine("Ne znam koja je to regija.");
                        */

            //-------------switch

            switch (grad)
            {
                case "Osijek":
                    Console.WriteLine("Regija Slavonija");
                    break;
                case "Zadar":
                    Console.WriteLine("Regija Dalmacija");
                    break;
                case "Čakovec":
                    Console.WriteLine("Regija Međimurje");
                    break;
                case "Pula":
                    Console.WriteLine("Regija Istra");
                    break;
                default:
                    Console.WriteLine("Ne znam koja je to regija");
                    break;
            }

        }
    }
}









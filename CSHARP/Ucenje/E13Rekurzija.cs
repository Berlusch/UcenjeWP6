using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E13Rekurzija
    {

        //Rekurzija je kada metoda zove samu sebe
        //uz uvjet prekida rekurzije
        public static void Izvedi()
        {

            //Izvedi(); stack overflow
            Console.WriteLine(Zbroji(100));
        }
        private static int Zbroji(int broj)
        {
            if (broj == 1)
            {
                return 1;
            }
            return broj + Zbroji(broj-1);
        }
        //100 + 99 + ...+1
    }
}

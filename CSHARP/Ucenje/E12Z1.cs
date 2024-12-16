using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{

    // Program za dva unesena broja ispisuje njihov zbroj

    internal class E12Z1
    {

        public static void Izvedi()
        {
            int pb = E12Metode.UcitajCijeliBroj("Unesi prvi broj: ");
            int db = E12Metode.UcitajCijeliBroj("Unesi drugi broj: ");

            Console.WriteLine("{0} + {1} = {2}",pb,db,pb+db);

        }

    }
}

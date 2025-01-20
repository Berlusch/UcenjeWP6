using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E19GenericiLambdaEkstenzije
{
    public static class Ekstenzije
    {
        public static void Ispisi(this Entitet e)
        {
            Console.WriteLine(e.Sifra);
        }
    }
}

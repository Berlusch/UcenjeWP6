using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{

    // Program unosi brojeve sve dok se ne unese broj -1
    // Program ispisuje zbroj svih unesenih brijeva

    internal class E09Z2
    {
        public static void Izvedi()
        {
            int suma = 0;
            int broj;

            do
            {
                Console.Write("Unesi cijeli broj: ");
                broj = int.Parse(Console.ReadLine());
                suma += broj;
            } while (broj != -1);

                Console.WriteLine(suma);
        }
    }
}

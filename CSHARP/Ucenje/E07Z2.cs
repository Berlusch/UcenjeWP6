using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E07Z2
    {
        // Za dva unesena cijela broja ispisati sve brojeve između njih
        public static void Izvedi()
        {
            Console.Write("Unesi jedan cijeli broj: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Unesi drugi cijeli broj: ");
            int b = int.Parse(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                Console.WriteLine(i);
            }

        }

    }
}

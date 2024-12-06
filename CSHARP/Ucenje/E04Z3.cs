using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje

    //Program od korisnika traži unos dva cijela broja
    //Program ispisuje manji

    //isti zadatak s tri broja 
{
    internal class E04Z3
    {
        public static void Izvedi()
        {
            Console.Write("Unesi jedan cijeli broj ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Unesi drugi cijeli broj ");
            int b = int.Parse(Console.ReadLine());  

            if(a<b)
            
            { Console.WriteLine("Manji broj je ", a);
            
            }
            else 
            {
                Console.WriteLine("Manji broj je ", b);
                    }


        }
    }
}

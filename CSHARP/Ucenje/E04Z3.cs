using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
<<<<<<< HEAD
{

    // Program od korisnika traži unos dva cijela broja
    // Program ispisuje manji

    // isti zadatak ali za tri unesena broja ispisati najmanji

    internal class E04Z3
    {
=======

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
>>>>>>> 6b5bbcef1a2b67d556a568dff19e946cca422870
    }
}

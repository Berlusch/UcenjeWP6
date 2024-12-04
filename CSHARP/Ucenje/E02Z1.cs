using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Ucenje
{



    // napišite program koji unosi ime i broj godina

    // program ispisuje: Osoba XXX ima YY godina
    internal class E02Z1
    {

        public static void Izvedi()
        {
            Console.Write("Upiši ime: ");
            string ime = Console.ReadLine();
            Console.Write("Upiši koliko imaš godina: ");
            int godine = int.Parse(Console.ReadLine());
            //Console.WriteLine("Osoba {0} ima {1} godina.", ime, godine);
            Console.WriteLine("Osoba " + ime + " ima " + godine + " godina.");
        }

            
       
        

        

    }
}

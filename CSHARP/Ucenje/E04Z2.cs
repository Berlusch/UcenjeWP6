using System;
using System.Collections.Generic;
using System.Linq;
<<<<<<< HEAD
=======
using System.Runtime.CompilerServices;
>>>>>>> 6b5bbcef1a2b67d556a568dff19e946cca422870
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{

<<<<<<< HEAD
    // Program od korisnika traži unos cijelog broja
    // Program ispisuje da li je uneseni broj paran ili ne


    internal class E04Z2
    {
        public static void Izvedi()
        {
            //Console.WriteLine("E04");
            Console.WriteLine("Unesi cijeli broj:");
            int broj = int.Parse(Console.ReadLine());
            if(broj%2 == 0)
            {
                Console.WriteLine("Paran.");
            }
            else
            {
                Console.WriteLine("Neparan.");
            }

            // sada dajte rješenje s inline if
=======
    //program od korisnika traži unos cijelog broja
    //program ispisuje da li je uneseni broj paran ili ne
    internal class E04Z2
    {

        public static void Izvedi()
        {
            Console.Write("Unesi cijeli broj: ");
            int broj = int.Parse(Console.ReadLine());

            if (broj % 2 == 0)
            {
                Console.WriteLine("Broj je paran");
            }
            else
            {
                Console.WriteLine("Broj je neparan");
            }

            //rješenje s inline if
          
            Console.WriteLine(broj % 2 == 0 ? "Broj je paran" : "Broj je neparan");
      

>>>>>>> 6b5bbcef1a2b67d556a568dff19e946cca422870

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E11TryCatch
    {

        public static void Izvedi()
        {
            //Console.WriteLine("E11");
            int broj;
            while (true)
            {
                try
                {
                    Console.Write("Unesi cijeli broj: ");
                    broj = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Nisi unio cijeli broj!");
                }
            }
            //Console.WriteLine("Bravo, unijeli ste {0}",broj);


            int godine;
            while (true)
            {
                Console.Write("Unesi svoj broj godina: ");
                try
                {
                    godine = int.Parse(Console.ReadLine());
                    if (godine < 1 || godine > 104)
                    {
                        Console.WriteLine("Uneseni broj godina nije dobar!");
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Nisi dobro unio broj godina");

                }
            }
            Console.WriteLine("Broj godina osobe je {0}", godine);

            // unesi grad
            string grad;
            int ascii;
            bool ok;
            for (; ; )
            {
                Console.Write("Unesi ime grada: ");
                grad = Console.ReadLine().Trim();
                if(grad.Length==0)
                {
                    Console.WriteLine("Nisi unio ime grada");
                    continue;
                }
                // ovdje sam siguran da je nešto unio

                try
                {
                    int.Parse(grad);
                    Console.WriteLine("Ime grada ne može biti broj");
                    continue;
                }
                catch 
                {

                    
                }
                // ovdje sam siguran da nije unio broj

                //problem 0sijek, Os!jek, Osi jek
                ok = true;
                foreach(char c in grad.ToUpper())
                {
                    ascii = (int)c;
                    if(ascii <65 || ascii > 90)
                    {
                        ok = false;
                        break;
                    }
                }
                if (!ok)
                {
                    Console.WriteLine("Problem s jednim od znakova u nazivu grada");
                    continue;
                }



                break;
            }
            Console.WriteLine("Unijeli ste: >{0}<",grad);





        }

    }
}

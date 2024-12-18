using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E13Z2
    {

        public static void Izvedi()
        {

            Zad2();

        }
        //Zad. 1 program unosi ime i ispisuje koliko ono ima znakova
        private static void Zad1()
        {
            Console.WriteLine("Dobro došli u prvi zadatak!");
            string ime;
            while (true)
            {
                ime = E12Metode.UcitajString("Unesi ime (NE za kraj): ");
                if (ime.ToUpper() == "NE")
                {
                    Console.WriteLine("Hvala na korištenju programa!");
                    break;
                }
                Console.WriteLine(ime.Length);

            }



        }
        //program unosi ime i prezime osobe odvojeno. Program ispisuje prezime i ime
        private static void Zad2()
        {
            string ime;
            string prezime;
            ime = E12Metode.UcitajString("Unesi ime: ");
            prezime = E12Metode.UcitajString("Unesi prezime: ");
            Console.WriteLine("{0} {1}", prezime,ime);
        }




    }
}

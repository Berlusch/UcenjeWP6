﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{


    // Program od korisnika traži unos broj godina koje ima korisnik
    // Program ispisuje da li je korisnik punoljetna osoba ili ne


    // dodatno: ako je unos ispod nula godine ili iznad 112 godina ipisasti GREŠKA

    //Program od korisnika traži unos broj godina koje ima korisnik
    //Program ispisuje da li je korisnik punoljetna osoba ili ne

    //dodatno: ako je unos ispod nula godine ili iznad 112 godina ispisati GREŠKA

    internal class E04Z1
    {
        public static void Izvedi()
        {


            //Console.WriteLine("Z1");
            Console.Write("Unesite godine: ");
            int godine = int.Parse(Console.ReadLine());

            if (godine >= 18)
            {
                if (godine > 112)
                    Console.WriteLine("Greška!");
                else
                    Console.WriteLine("Punoljetan");
            }


            else
            {
                if (godine < 0)
                    Console.WriteLine("Greška!");
            else
                Console.WriteLine("Maloljetan");

            }


        }
    }


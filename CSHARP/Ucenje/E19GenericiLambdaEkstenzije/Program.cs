﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E19GenericiLambdaEkstenzije
{
    internal class Program
    {
        public Program()
        {
            Console.WriteLine("E19");
            //problem nizova je unaprijed se mora znati broj elemenata. Rješenje je lista.

            List<int> brojevi= new List<int>();

            brojevi.Add(7);
            brojevi.Add(2);
            // brojevi.Add("2"); ne može string u int

            Console.WriteLine(brojevi[1]);


            var gradovi= new List<string>();

            gradovi.Add("Osijek");
            gradovi.Add("Zadar");

            foreach(string grad in gradovi)
            {
                Console.WriteLine(grad);
            }

            var smjerovi = new List<Smjer>();
            smjerovi.Add(new() { Naziv = "Web programiranje" });
            smjerovi.Add(new() { Naziv = "Autolimar" });

            var s = new Smjer();
            s.Sifra = 1;
            s.Naziv = "Serviser";
            smjerovi.Add(s);

            Console.WriteLine(smjerovi[0].StariNaziv());

            var o = new Obrada<Smjer>();

            o.ObjektObrade = s;

            //var o1=new Obrada<string>(); ne može jer T u Obrada nasljeđuje Entitet

            //o1.ObjektObrade = "s";

            foreach(var smjer in smjerovi)
            {
                Console.WriteLine(smjer.Naziv);
            }

            smjerovi.Sort();//metoda koja se oslanja na IComparable sučelje

            Console.WriteLine("***********************");
            foreach(var smjer in smjerovi)
            {
                Console.WriteLine(smjer.Naziv);
            }

            smjerovi.Reverse();


            //Kreirajte listu datuma.
            //u listu stavite datum svog rođenja i današnji datum

            List<DateTime> datumi = new List<DateTime>();
            datumi.Add(new DateTime(1975, 6, 30));
            datumi.Add(DateTime.Now);

            foreach(var d in datumi)
            {
                Console.WriteLine(d);
            }

            //lambda izrazi

            Console.WriteLine(KlasicnaMetoda(5,5));

            // => lambda

            // ovdje sada lagano c# odskače od OOP principa
            var Zbroj=(int a, int b)=> a+b; //(gledajući s ove linije Zbroj je varijabla)

            Console.WriteLine(Zbroj(5,5));//gledajući s ove linije Zbroj je metoda

            //kompleksnija sintaksa

            var Algoritam = (int x, int y) =>
            {
                var z = 0;
                z = ++x;
                y += z;
                return x + y + z;
            };

            Console.WriteLine(Algoritam(2,3));

            //parnost broja pomoću lambda izraza

            var Parni = (int i) => i % 2 == 0;

            Console.WriteLine(Parni(7)? "Parni":"Neparni");

            //ekstenzije - odskače od OOP-a

            String ime = "Ana";
            Console.WriteLine(ime.LastOrDefault());

            Console.WriteLine(smjerovi.LastOrDefault());

            //korištenje vlastite ekstenzije

            s.Ispisi();

            var p = new Polaznik() { Sifra = 7, Ime = "Pero" };

            p.Ispisi();

            // zadnji krik neOOP-a u OOP jeziku je definiranje objekta on the fly

            var nesto = new
            {
                Ime = "Pero",
                Grad = "Osijek",
                Smjer = s
            };

            

        }
        private int KlasicnaMetoda(int a, int b)
        {
            return a + b;
        }

    }
}

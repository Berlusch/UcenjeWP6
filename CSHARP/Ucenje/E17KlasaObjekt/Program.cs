using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ucenje.E17KlasaObjekt.edunova;

namespace Ucenje.E17KlasaObjekt
{
    public class Program
    {
        // 5. vrsta metode (posebna) konstruktor
        // konstruktor mora imati isti naziv kao i klasa a lista parametara može biti različiti
        public Program() {
            // Objekt je instanca (pojavnost) klase

            // Osoba je ime klasa (primjeriti veliko početno slovo O)
            // osoba je ime objekta (instance/pojavnosti) - varijabla  (primjeriti malo početno slovo o)
            Osoba osoba = new Osoba();

            osoba.Sifra = 1;

            //Osoba.Sifra na klasi ne postoji svojstvo, ono je na objektu

            osoba.Ime = "Pero"; //E12Metode.UcitajString("Unesi ime");
            osoba.Prezime = "Perić";

            Console.WriteLine(osoba.Ime);


            osoba = new Osoba() { 
                Sifra=2,
                Ime="Karlo",
                Prezime="Lik"
            };

            Console.WriteLine("{0} {1}",osoba.Ime, osoba.Prezime);
            Console.WriteLine(osoba.ImePrezime());

            Osoba.Izvedi();
            //Console.WriteLine(osoba.Izvedi()); Ne možeš pozvati statičnu metodu na objektu (malo slovo o), već samo na klasi - prethodna linija

            Mjesto mjesto = new Mjesto() { Naziv="Osijek",PostanskiBroj="31000"};

            //osoba.Mjesto = mjesto;

            // ispiši Osijek
            //Console.WriteLine(osoba.Mjesto.Naziv); // imamo nullreferenceexception

            // stari način
            if (osoba.Mjesto != null)
            {
                Console.WriteLine(osoba.Mjesto.Naziv);
            }

            //kraći način
            Console.WriteLine(osoba.Mjesto?.Naziv); // ? je ovdje indikacija da ne pukne ako je null


            osoba.Mjesto = new Mjesto() { Naziv = "Osijek" };

            Console.WriteLine(osoba.Mjesto.Zupanija?.Zupan ?? "Prazno"); // nakon ?? ide vrijednost koja se koristi ako je svojstvo null


            Smjer smjer = new Smjer() { Naziv = "Web programiranje" };

            Grupa grupa = new () {Naziv="WP6",Smjer=smjer}; //još kraće


            Polaznik[] polazniciNiz = new Polaznik[2];

            polazniciNiz[0] = new Polaznik() { Ime = "Pero" };
            polazniciNiz[1] = new Polaznik() { Ime = "Marija" };

            grupa.Polaznici = polazniciNiz;

            //ispisati podatke o grupe
            Console.WriteLine(grupa.Naziv);
            Console.WriteLine(grupa.Smjer.Naziv);
            foreach(Polaznik p in grupa.Polaznici)
            {
                Console.WriteLine("{0} {1}", p.Ime, p.Prezime);
            }

            Console.WriteLine("*************************");
            grupa.DetaljiGrupe();

        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ucenje.UdomiMeKonzolnaAplikacija.Model;
using Faker;


namespace Ucenje.UdomiMeKonzolnaAplikacija
{
    public class ObradaUdomitelj
    {

        public List<Udomitelj> Udomitelji { get; set; }

        public ObradaUdomitelj()
        {

            Udomitelji = new List<Udomitelj>();
            if (Pomocno.DEV)
            {
                UcitajTestnePodatke();
            }
        }

        private void UcitajTestnePodatke()
        {
            for (int i = 0; i < 10; i++)
            {
                Udomitelji.Add(new()
                {
                    Ime = Faker.Name.First(),
                    Prezime = Faker.Name.Last()
                });
            }
        }

        public void PrikaziIzbornik()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Izbornik za rad s udomiteljima");
            Console.ResetColor();
            Console.WriteLine("------------------------------");
            Console.WriteLine("1. Pregled svih udomitelja");
            Console.WriteLine("2. Unos novog udomitelja");
            Console.WriteLine("3. Promjena podataka postojećeg udomitelja");
            Console.WriteLine("4. Brisanje udomitelja");
            Console.WriteLine("5. Povratak na glavni izbornik");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
            Console.WriteLine();
            switch (Pomocno.UcitajRasponBroja("Odaberite stavku izbornika", 1, 5))
            {
                case 1:
                    PrikaziUdomitelje();
                    PrikaziIzbornik();
                    break;
                case 2:
                    UnosNovogUdomitelja();
                    PrikaziIzbornik();
                    break;
                case 3:
                    PromijeniPodatkeUdomitelja();
                    PrikaziIzbornik();
                    break;
                case 4:
                    ObrisiUdomitelja();
                    PrikaziIzbornik();
                    break;
                case 5:
                    Console.Clear();
                    break;
            }
        }

        private void ObrisiUdomitelja()
        {
            PrikaziUdomitelje();
            var odabrani = Udomitelji[
                Pomocno.UcitajRasponBroja("Odaberi redni broj udomitelja za brisanje",
                1, Udomitelji.Count) - 1
                ];
            if (Pomocno.UcitajBool("Jeste li sigurni da zelite obrisati udomitelja " + odabrani.Ime + " " + odabrani.Prezime + "? (DA/NE)", "da"))
            {
                Udomitelji.Remove(odabrani);
            }
        }

        private void PromijeniPodatkeUdomitelja()
        {
            PrikaziUdomitelje();
            var odabrani = Udomitelji[
                Pomocno.UcitajRasponBroja("Odaberi redni broj udomitelja za promjenu: ",
                1, Udomitelji.Count) - 1
                ];
            odabrani.Sifra = Pomocno.UcitajRasponBroja("Unesi šifru udomitelja: ", 1, int.MaxValue);
            odabrani.Ime = Pomocno.UcitajString(odabrani.Ime, "Unesi ime udomitelja: ", 50, true);
            odabrani.Prezime = Pomocno.UcitajString("Unesi prezime udomitelja: ", 50, true);
            odabrani.Adresa = Pomocno.UcitajString("Unesi adresu udomitelja: ", 50, true);
            odabrani.Telefon = Pomocno.UcitajString("Unesi telefon udomitelja: ", 50, true);
            odabrani.Email = Pomocno.UcitajString("Unesi email udomitelja: ", 50, true);

        }
        public void PrikaziUdomitelje()
        {
            PrikaziUdomitelje(Udomitelji, "Popis udomitelja u aplikaciji");
        }

        public void PrikaziUdomitelje(List<Udomitelj> udomiteljiLista, string naslov)
        {
            Console.WriteLine("--------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(naslov);
            Console.ResetColor();
            Console.WriteLine("--------------------------");
            
            int rb = 0;
            foreach (var u in udomiteljiLista)
            {
                Console.WriteLine(++rb + ". " + u.Ime+" "+u.Prezime);
            }
            
           
            
        }

        public void UnosNovogUdomitelja()
        {
            Console.WriteLine("***************************");
            Console.WriteLine("Unesite tražene podatke o udomitelju");
            Udomitelji.Add(new()
            {
                Sifra = Pomocno.UcitajRasponBroja("Unesi šifru udomitelja: ", 1, int.MaxValue),
                Ime = Pomocno.UcitajString("Unesi ime udomitelja: ", 50, true),
                Prezime = Pomocno.UcitajString("Unesi prezime udomitelja: ", 50, true),
                Adresa = Pomocno.UcitajString("Unesi adresu udomitelja: ", 50, true),
                Telefon = Pomocno.UcitajString("Unesi telefon udomitelja: ", 50, true),
                Email = Pomocno.UcitajString("Unesi email udomitelja: ", 50, true),

            });
            PotvrdaUnosa();
        }
        public static bool PotvrdaUnosa()
        {
            Console.WriteLine("Želite li spremiti promjene? (da/ne)");
            string potvrdaUnosa = Console.ReadLine().ToLower();

            if (potvrdaUnosa == "da")
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("Podatci su spremljeni, hvala.");
                Console.WriteLine();

                return true;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Odustali ste od unosa.");
                Console.WriteLine("-------------------------------");
                ObradaUdomitelj obradaUdomitelj = new ObradaUdomitelj();
                obradaUdomitelj.ResetirajUnesenePodatke();
                obradaUdomitelj.PrikaziIzbornik();
                return false;
            }
        }
        private void ResetirajUnesenePodatke()
        {
            if (Udomitelji.Count > 0)
            {
                Udomitelji.RemoveAt(Udomitelji.Count - 1);
            }
        }




    }
}

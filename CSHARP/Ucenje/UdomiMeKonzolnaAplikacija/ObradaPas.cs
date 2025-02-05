using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ucenje.UdomiMeKonzolnaAplikacija.Model;



namespace Ucenje.UdomiMeKonzolnaAplikacija
{
    internal class ObradaPas : Pas
    {

        public List<Pas> Psi { get; set; }

        public ObradaPas()
        {
            Psi = new List<Pas>();
            if (Pomocno.DEV)
            {
                UcitajTestnePodatke();
            }
        }

        private void UcitajTestnePodatke()
        {
            Psi.Add(new() { Ime = "Bergo" });
            Psi.Add(new() { Ime = "Gita" });
            Psi.Add(new() { Ime = "Lesi" });
        }

        public void PrikaziIzbornik()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Izbornik za rad sa psima");
            Console.ResetColor();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("1. Pregled svih pasa");
            Console.WriteLine("2. Pregled detalja pojedinog psa");
            Console.WriteLine("3. Unos novog psa");
            Console.WriteLine("4. Promjena podataka postojećeg psa");
            Console.WriteLine("5. Obriši psa");
            Console.WriteLine("6. Povratak na glavni izbornik");
            Console.WriteLine();
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
            switch (Pomocno.UcitajRasponBroja("Odaberite stavku izbornika", 1, 6))
            {
                case 1:
                    PrikaziPse();
                    PrikaziIzbornik();
                    break;
                case 2:
                    PregledDetaljaPojedinogPsa();
                    PrikaziIzbornik();
                    break;
                case 3:
                    UnosNovogPsa();
                    PrikaziIzbornik();
                    break;
                case 4:
                    PromijeniPostojecegPsa();
                    PrikaziIzbornik();
                    break;
                case 5:
                    ObrisiPostojecegPsa();
                    PrikaziIzbornik();
                    break;
                case 6:
                    Console.Clear();
                    break;
            }
        }

        private void PregledDetaljaPojedinogPsa()
        {
            PrikaziPse();
            var p = Psi[
                Pomocno.UcitajRasponBroja("Odaberi redni broj psa za detalje", 1, Psi.Count) - 1
                ];
            Console.WriteLine("--------------------");
            Console.WriteLine("Detalji psa: ");
            Console.WriteLine();
            Console.WriteLine("Šifra: " + p.Sifra);
            Console.WriteLine("Broj čipa: " + p.BrojCipa);
            Console.WriteLine("Ime: " + p.Ime);
            Console.WriteLine("Pasmina: " + p.Pasmina);
            Console.WriteLine("Datum rođenja: " + p.Datum_Rodjenja);
            Console.WriteLine("Spol: " + p.SpolVrsta);
            Console.WriteLine("Veličina: " + p.VelicinaPsa);
            Console.WriteLine("Boja: " + p.BojaPsa);
            Console.WriteLine("Moja priča: " + p.MojaPrica);
            Console.WriteLine($"Kastracija: {Pomocno.BoolToYesNo(p.Kastracija)}");
            Console.WriteLine("Status: " + p.StatusOpis);
            //Console.WriteLine("Datum zadnje izmjene: " + p.DatumPromjene.Value.ToString("dd. MM. yyyy. HH:mm:ss"));
            Console.WriteLine("--------------------");
        }

        private void ObrisiPostojecegPsa()
        {
            PrikaziPse();
            var odabrani = Psi[Pomocno.UcitajRasponBroja("Odaberi redni broj psa za brisanje",
                1, Psi.Count) - 1];

            if (Pomocno.UcitajBool("Sigurno želite obrisati sljedećeg psa: " + odabrani.Ime + "? (DA/NE)", "da"))
            {
                Psi.Remove(odabrani);
            }

        }

        private void PromijeniPostojecegPsa()
        {
            PrikaziPse();
            var odabrani = Psi[Pomocno.UcitajRasponBroja("Odaberi redni broj psa za promjenu",
                1, Psi.Count) - 1];
            int indeksOdabranog = Psi.IndexOf(odabrani);

            if (Pomocno.UcitajRasponBroja("1. Promjena svih podataka\n2. Pojedinačna promjena\n\nOdaberite broj tipa promjene: ", 1, 2) == 1)
            {
                // poziv API-u da se javi tko ovo koristi
                odabrani.Sifra = Pomocno.UcitajRasponBroja("Unesite šifru psa: ", 1, 10000);
                odabrani.Ime = Pomocno.UcitajString("Unesite ime psa: ", 50, true);
                odabrani.BrojCipa = Pomocno.UcitajString("Unesite broj čipa psa: ", 17, true);
                odabrani.Datum_Rodjenja = Pomocno.UcitajDatum("Unesite datum rodjenja psa: ", false);
                odabrani.SpolVrsta = Pomocno.UcitajEnum<Pas.Spol>("Unesi spol (m/ž): ");
                odabrani.VelicinaPsa = Pomocno.UcitajEnum<Velicina>("Unesi veličinu (veliki/srednji/mali): ");
                odabrani.BojaPsa = Pomocno.UcitajEnum<Boja>("Unesi boju (bijeli, crni, smeđi, šareni): ");
                odabrani.MojaPrica = Pomocno.UcitajString("Unesi ime psa: ", 500, true);
                odabrani.Kastracija = Pomocno.UcitajBool("Je li pas kastriran/steriliziran? (DA/NE): ", "da");
                odabrani.StatusOpis = Pomocno.UcitajEnum<StatusEnum>("Odaberite status (udomljen/rezerviran/slobodan/privremeni smještaj)");

            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Promjena podataka za psa {0}", odabrani.Ime);
                Console.WriteLine("-------------------------------");
                // poziv API-u da se javi tko ovo koristi
                switch (Pomocno.UcitajRasponBroja("1. Šifra\n2. Ime\n3. Broj čipa\n4. Datum rođenja\n5. Spol\n6. Veličina\n7. Boja\n8. Moja priča\n9. Kastracija\n10. Status\n" +
                    "------------------------------------------------------\nOdaberite broj stavke koju želite promijeniti: ", 1, 11))
                {
                    case 1:
                        odabrani.Sifra = Pomocno.UcitajRasponBroja("Unesi šifru psa: ", 1, 10000);
                        break;
                    case 2:
                        odabrani.Ime = Pomocno.UcitajString("Unesi ime psa: ", 50, true);
                        break;
                    case 3:
                        odabrani.BrojCipa = Pomocno.UcitajString("Unesi broj čipa psa: ", 17, true);
                        break;
                    case 4:
                        odabrani.Datum_Rodjenja = Pomocno.UcitajDatum("Unesi datum rođenja psa: ", false);
                        break;
                    case 5:
                        odabrani.SpolVrsta = Pomocno.UcitajEnum<Pas.Spol>("Unesi spol (m/ž): ");
                        break;
                    case 6:
                        odabrani.VelicinaPsa = Pomocno.UcitajEnum<Velicina>("Unesi veličinu (veliki/srednji/mali): ");
                        break;
                    case 7:
                        odabrani.BojaPsa = Pomocno.UcitajEnum<Boja>("Unesi boju (bijeli, crni, smeđi, šareni): ");
                        break;
                    case 8:
                        odabrani.MojaPrica = Pomocno.UcitajString("Moja priča: ", 500, true);
                        break;
                    case 9:
                        odabrani.Kastracija = Pomocno.UcitajBool("Je li pas kastriran/steriliziran? (DA/NE): ", "da");
                        break;
                    case 10:
                        odabrani.StatusOpis = Pomocno.UcitajEnum<StatusEnum>("Odaberite status (udomljen/rezerviran/slobodan/privremeni smještaj)");
                        break;

                }
            }
            
            odabrani.DatumPromjene = DateTime.Now;





            // gornjih 6 linija igra istu ulogu kao na 93 - 98. Izvući u metodu

        }

        public void PrikaziPse()
        {
            Console.WriteLine("*****************************");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Psi u aplikaciji: ");
            Console.ResetColor();
            Console.WriteLine("----------------");
            int rb = 0;
            foreach (var p in Psi)
            {
                Console.WriteLine(++rb + ". " + p.Ime);
            }
            Console.WriteLine("****************************");
        }

        private void UnosNovogPsa()
        {
            Console.WriteLine("***************************");
            Console.WriteLine("Unesite tražene podatke o psu");
            Psi.Add(new()
            {
                Sifra = Pomocno.UcitajRasponBroja("Unesite šifru psa: ", 1, 10000),
                Ime = Pomocno.UcitajString("Unesite ime psa: ", 50, true),
                BrojCipa = Pomocno.UcitajString("Unesite broj čipa psa: ", 17, false),
                Pasmina = Pomocno.UcitajString("Unesite pasminu psa: ", 50, false),
                Datum_Rodjenja = Pomocno.UcitajDatum("Unesite datum rođenja psa: ", false),
                SpolVrsta = Pomocno.UcitajEnum<Pas.Spol>("Unesi spol (m/ž): "),
                VelicinaPsa = Pomocno.UcitajEnum<Velicina>("Odaberite veličinu psa (veliki, srednji, mali): "),
                BojaPsa = Pomocno.UcitajEnum<Boja>("Unesi boju (bijeli, crni, smeđi, šareni): "),
                MojaPrica = Pomocno.UcitajString("Moja priča: ", 500, true),
                Kastracija = Pomocno.UcitajBool("Je li pas kastriran/steriliziran? (DA/NE): ", "da"),
                StatusOpis = Pomocno.UcitajEnum<StatusEnum>("Odaberite status (udomljen/rezerviran/slobodan/privremeni smještaj)"),
                DatumPromjene = DateTime.Now
            });
            
            

        }
        


        /*private void ResetirajUnesenePodatke()
        {
            
            if (Psi.Count > 0)
            {
                Psi.RemoveAt(Psi.Count-1);
            }
        }*/
        
    }
}


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
            Console.WriteLine("Izbornik za rad sa psima");
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
                    PromjeniPostojecegPsa();
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

        private void PromjeniPostojecegPsa()
        {
            PrikaziPse();
            var odabrani = Psi[Pomocno.UcitajRasponBroja("Odaberi redni broj psa za promjenu",
                1, Psi.Count) - 1];

            if (Pomocno.UcitajRasponBroja("1. Mjenjaš sve\n2. Pojedinačna promjena", 1, 2) == 1)
            {
                // poziv API-u da se javi tko ovo koristi
                odabrani.Sifra = Pomocno.UcitajRasponBroja("Unesite šifru psa: ", 1, 10000);
                odabrani.Ime = Pomocno.UcitajString("Unesite ime psa: ", 50, true);
                odabrani.BrojCipa = Pomocno.UcitajString("Unesite broj čipa psa: ", 17, true);
                odabrani.Datum_Rodjenja = Pomocno.UcitajDatum("Unesite datum rodjenja psa: ", false);
                odabrani.SpolVrsta = Pomocno.UcitajEnum<Pas.Spol>("Unesi spol (m/ž): ", "m");
                odabrani.VelicinaPsa = Pomocno.UcitajEnum<Velicina>("Unesi veličinu (veliki/srednji/mali): ", "Veliki");
                odabrani.BojaPsa = Pomocno.UcitajEnum<Boja>("Unesi boju (bijeli, crni, smeđi, šareni): ", "Bijeli");
                odabrani.MojaPrica = Pomocno.UcitajString("Unesi ime psa: ", 500, true);
                odabrani.Kastracija = Pomocno.UcitajBool("Je li pas kastriran/steriliziran? (DA/NE): ", "da");
                odabrani.StatusOpis = Pomocno.UcitajEnum<StatusEnum>("Odaberite status (udomljen/rezerviran/slobodan/privremeni smještaj)", "udomljen");

            }
            else
            {
                // poziv API-u da se javi tko ovo koristi
                switch (Pomocno.UcitajRasponBroja("1. Šifra\n2. Ime\n3. BrojCipa\n" +
                    "5. Vaučer", 1, 5))
                {
                    case 1:
                        odabrani.Sifra = Pomocno.UcitajRasponBroja("Unesi šifru psa: ", 1, 10000);
                        break;
                    case 2:
                        odabrani.Ime = Pomocno.UcitajString("Unesi ime psa: ", 50, true);
                        break;
                    // ... ostali
                    case 5:
                        odabrani.BrojCipa = Pomocno.UcitajString("Unesi ime psa: ", 17, true);
                        break;

                }
            }
            odabrani.DatumPromjene = DateTime.Now;




            // gornjih 6 linija igra istu ulogu kao na 93 - 98. Izvući u metodu

        }

        public void PrikaziPse()
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("Psi u aplikaciji");
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
                Datum_Rodjenja = Pomocno.UcitajDatum("Unesite datum rođenja psa: ", false),
                SpolVrsta = Pomocno.UcitajEnum<Pas.Spol>("Unesi spol (m/ž): ", "m"),
                VelicinaPsa = Pomocno.UcitajEnum<Velicina>("Unesi veličinu (veliki/srednji/mali): ", "Veliki"),
                BojaPsa = Pomocno.UcitajEnum<Boja>("Unesi boju (bijeli, crni, smeđi, šareni): ", "Bijeli"),
                MojaPrica = Pomocno.UcitajString("Moja priča: ", 500, true),
                Kastracija = Pomocno.UcitajBool("Je li pas kastriran/steriliziran? (DA/NE): ", "da"),
                StatusOpis = Pomocno.UcitajEnum<StatusEnum>("Odaberite status (udomljen/rezerviran/slobodan/privremeni smještaj)", "udomljen"),
                DatumPromjene = DateTime.Now
            });
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E16ZimskiZadaci
    {

        public static void Izvedi()
        {
            //Console.WriteLine("E16");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\x1b[1mDobro došli u zimske zadatke!\x1b[0m");
            Console.ResetColor();
            Izbornik();
            Console.WriteLine("Hvala na korištenju zimskih zadataka!");

        }

        private static void Izbornik()
        {
            string[] programi =
            {
                "Izračun površine pravokutnika",
                "Pozitivan ili negativan broj?",
                "Zbroj elemenata niza",
                "Prosjek ocjena",
                "Fibonaccijev niz",
                "Preokret stringa",
                "Brojanje samoglasnika",
                "Pretvorba temperature",
                "Sortiranje niza",
                "Kalkulator"

            };

            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("IZBORNIK");
            Console.ResetColor();
            Console.WriteLine();
            for (int i = 0; i < programi.Length; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, programi[i]);
            }

            Console.WriteLine("0. Izlaz iz programa");
            Console.WriteLine();
            OdabirOpcijeIzbornika(programi.Length);

        }
        private static void OdabirOpcijeIzbornika(int BrojPrograma)
        {
            switch (E12Metode.UcitajCijeliBroj("Odaberi stavku izbornika: ", 0, BrojPrograma))
            {
                case 0:
                    break;
                case 1:
                    IzracunPovrsinePravokutnika();
                    Izbornik();
                    break;
                case 2:
                    PozitivanNegativanBroj();
                    Izbornik();
                    break;
                case 3:
                    ZbrojElemenataNiza();
                    Izbornik();
                    break;
                case 4:
                    ProsjekOcjena();
                    Izbornik();
                    break;
                case 5:
                    FibonaccijevNiz();
                    Izbornik();
                    break;
                case 6:
                    PreokretStringa();
                    Izbornik();
                    break;
                case 7:
                    BrojanjeSamoglasnika();
                    Izbornik();
                    break;
                case 8:
                    PretvorbaTemperature();
                    Izbornik();
                    break;
                case 9:
                    SortiranjeNiza();
                    Izbornik();
                    break;
                case 10:
                    Kalkulator();
                    Izbornik();
                    break;
            }
        }

        private static void Kalkulator()
        {
            NaslovPrograma("Kalkulator");
            Console.WriteLine();
            
            Console.WriteLine();
            Console.WriteLine("IZBORNIK");
            Console.WriteLine();
            Console.WriteLine("+ (zbrajanje)");
            Console.WriteLine("- (oduzimanje)");
            Console.WriteLine("* (množenje)");
            Console.WriteLine("/ (dijeljenje)");
            Console.WriteLine();

            bool izlaz = false;
            while (!izlaz)
            {
                double x = E12Metode.UcitajCijeliBroj("Unesite prvi broj: ");
                double y = E12Metode.UcitajCijeliBroj("Unesite drugi broj: ");
                Console.Write("Odaberite operaciju (+, -, *, / (za izlaz upišite 0): ");
                char operacija = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (operacija)
                {
                    case '+':

                        Console.WriteLine();
                        Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
                        Console.WriteLine();
                        break;
                    case '-':

                        Console.WriteLine();
                        Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
                        Console.WriteLine();
                        break;
                    case '*':

                        Console.WriteLine();
                        Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
                        Console.WriteLine();
                        break;
                    case '/':

                        Console.WriteLine();
                        Console.WriteLine("{0} / {1} = {2}", x, y, Math.Round(x / y, 2));
                        Console.WriteLine();
                        break;
                    case '0':
                        Console.WriteLine();
                        Console.WriteLine("Hvala na korištenju kalkulatora i doviđenja!");
                        Console.WriteLine();
                        izlaz = true; 
                        break;
                    default:
                        Console.WriteLine("Nepoznata opcija, pokušajte ponovno!");
                        break;
                        
                        

                }

            }

        }

        private static void SortiranjeNiza()
        {
            NaslovPrograma("Sortiranje niza");
            int brojBrojeva = E12Metode.UcitajCijeliBroj("Koliko brojeva želite sortirati?  ");
            int[] brojevi = new int[brojBrojeva];
            Console.WriteLine("Unesite {0} brojeva u niz.", brojBrojeva);
            for (int i = 0; i < brojBrojeva; i++)
            {
                int broj = E12Metode.UcitajCijeliBroj($"Unesite {i + 1}. broj: ");
                brojevi[i] = broj;

            }
            Console.WriteLine();
            Console.Write("Unijeli ste: ");
            Console.WriteLine(string.Join(", ", brojevi));
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Niz sortiran uzlazno: ");
            Array.Sort(brojevi);
            Console.Write(string.Join(", ", brojevi));
            Console.WriteLine();
            Console.Write("Niz sortiran silazno: ");
            Array.Reverse(brojevi);
            Console.Write(string.Join(", ", brojevi));
            Console.ResetColor();
            Console.WriteLine();

        }

        private static void PretvorbaTemperature()
        {
            NaslovPrograma("Pretvorba temperature");
            Console.WriteLine();
            Console.WriteLine("IZBORNIK");
            Console.WriteLine("1. Pretvorba °C u °F");
            Console.WriteLine("2. Pretvorba °F u °C ");
            Console.WriteLine();
            switch (E12Metode.UcitajCijeliBroj("Odaberite opciju pretvorbe temperature: ", 0, 2))
            {
                case 0:
                    break;
                case 1:
                    Console.WriteLine("1. Pretvorba °C u °F");
                    CelzijFahrenheit();
                    break;
                case 2:
                    Console.WriteLine("2. Pretvorba °F u °C");
                    FahrenheitCelzij();
                    break;

            }

        }

        private static void FahrenheitCelzij()
        {
            double fahrenheit = E12Metode.UcitajCijeliBroj("Unesite temperaturu u °F: ");
            double celsius = (fahrenheit - 32) / 1.8;
            Console.WriteLine("{0}°F = {1}°C", fahrenheit, celsius);
        }

        private static void CelzijFahrenheit()
        {
            double celsius = E12Metode.UcitajCijeliBroj("Unesite temperaturu u °C: ");
            double fahrenheit = (celsius * 1.8) + 32;
            Console.WriteLine("{0}°C = {1}°F", celsius, fahrenheit);
        }

        private static void BrojanjeSamoglasnika()
        {
            NaslovPrograma("Brojanje samoglasnika");
            int sum = 0;
            string[] samoglasnici = ["a", "e", "i", "o", "u"];
            string upis = E12Metode.UcitajString("Unesite riječ ili rečenicu: ");
            foreach (char slovo in upis)
            {
                if (String.Join("", samoglasnici).Contains(slovo))
                {
                    sum += 1;
                }
            }
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("U vašem upisu ima {0} ", sum + " samoglasnika.");
            Console.ResetColor();
        }





        private static void PreokretStringa()
        {
            NaslovPrograma("Preokret stringa");
            string unos;
            while (true)
            {
                try
                {
                    unos = E12Metode.UcitajString("Unesite pojam ili niz znakova (2-30): ");
                    if (unos.Length < 2 || unos.Length > 30)
                    {
                        Console.WriteLine("Broj znakova je izvan dozvoljenog raspona, pokušajte ponovno!");
                        continue;
                    }
                    break;
                }
                catch
                {


                }

            }
            char[] preokret = new char[unos.Length];
            for (int i = 0; i < unos.Length; i++)
            {
                preokret[i] = unos[unos.Length - 1 - i];

            }
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Obrnuti redoslijed znakova je ");
            Console.WriteLine(string.Concat(preokret));
            Console.ResetColor();
        }

        private static void FibonaccijevNiz()
        {
            NaslovPrograma("Fibonaccijev niz");
            int n;
            while (true)
            {
                try
                {
                    n = E12Metode.UcitajCijeliBroj("Unesite broj n za ispis prvih n brojeva Fibonaccijeva niza (2-20): ");
                    if (n < 2 || n > 20)
                    {
                        Console.WriteLine("Unešeni broj je izvan raspona, pokušajte ponovno!");
                        continue;
                    }
                    break;
                }

                catch
                {

                }
            }
            int[] niz = new int[n];
            niz[0] = 1;
            niz[1] = 1;

            for (int i = 2; i < n; i++)
            {
                niz[i] = niz[i - 1] + niz[i - 2];

            }
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            if (n <= 4)
            {
                Console.Write("Prva {0} broja Fibonaccijeva niza: ", n);
            }
            else
            {
                Console.Write("Prvih {0} brojeva Fibonaccijeva niza: ", n);
            }
            Console.WriteLine(string.Join(", ", niz));
            Console.ResetColor();


        }

        private static void ProsjekOcjena()
        {
            NaslovPrograma("Prosjek ocjena");
            int brojOcjena;
            while (true)
            {
                try
                {
                    Console.Write("Unesi željeni broj ocjena (najviše 20): ");
                    brojOcjena = int.Parse(Console.ReadLine());
                    if (brojOcjena < 1 || brojOcjena > 20)
                    {
                        Console.WriteLine("Nisi unio dobar broj, pokušaj ponovno!");
                        continue;
                    }
                    break;

                }
                catch
                {
                    Console.WriteLine("Nisi dobro unio broj!");
                }

            }
            Console.WriteLine();
            Console.WriteLine("Broj ocjena je {0}. Sad unesi jednu po jednu ocjenu: ", brojOcjena);


            int[] niz = new int[brojOcjena];
            int sum = 0;

            for (int i = 0; i < brojOcjena; i++)
            {
                int ocjena = E12Metode.UcitajCijeliBroj($"Unesi ocjenu broj {i + 1}: ");
                niz[i] = ocjena;
                sum += ocjena;

            }
            decimal prosjek = (decimal)sum / brojOcjena;
            prosjek = Math.Round(prosjek, 2);

            Console.WriteLine();
            Console.Write("Unio si sljedeće ocjene: ");
            Console.WriteLine(string.Join(", ", niz));
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write($"Prosjek ocjena je {prosjek}");
            Console.ResetColor();
            Console.WriteLine();
        }

        private static void ZbrojElemenataNiza()
        {
            NaslovPrograma("Zbroj elemenata niza");

            int velicinaNiza;
            while (true)
            {
                try
                {
                    Console.Write("Unesi željeni broj cijelih brojeva u nizu (2-10): ");
                    velicinaNiza = int.Parse(Console.ReadLine());
                    if (velicinaNiza < 2 || velicinaNiza > 10)
                    {
                        Console.WriteLine("Nisi unio dobar broj, pokušaj ponovno!");
                        continue;
                    }
                    break;

                }
                catch
                {
                    Console.WriteLine("Nisi dobro unio broj!");
                }

            }
            Console.WriteLine();
            Console.WriteLine("U redu, broj članova niza je {0}. Sad unesi jedan po jedan broj.", velicinaNiza);


            int[] niz = new int[velicinaNiza];
            int sum = 0;

            for (int i = 0; i < (velicinaNiza); i++)
            {
                int broj = E12Metode.UcitajCijeliBroj($"Unesi {i + 1}. broj: ");
                niz[i] = broj;
                sum += broj;

            }

            Console.WriteLine();
            Console.Write("Unio si sljedeći niz: ");
            Console.WriteLine(string.Join(", ", niz));
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"Zbroj elemenata ovog niza je {sum}.");
            Console.ResetColor();


        }

        private static void IzracunPovrsinePravokutnika()
        {
            NaslovPrograma("Izračun površine pravokutnika");
            int a = E12Metode.UcitajCijeliBroj("Unesi duljinu stranice pravokutnika: ");
            int b = E12Metode.UcitajCijeliBroj("Unesi širinu stranice pravokutnika: ");

            Console.WriteLine("Površina pravokutnika duljina stranica {0} i {1} je {2}", a, b, a * b);
        }
        private static void PozitivanNegativanBroj()
        {
            NaslovPrograma("Pozitivan ili negativan broj?");
            int i = E12Metode.UcitajCijeliBroj("Unesi jedan cijeli broj: ");
            if (i < 0)
            {
                Console.WriteLine("Broj je negativan!");
            }
            if (i > 0)
            {
                Console.WriteLine("Broj je pozitivan!");
            }
            else
            {
                Console.WriteLine("Broj je 0!");
            }
        }
        private static void NaslovPrograma(string naslov)
        {
            //Console.WriteLine("***************");
            NaglasiNaslov(naslov.Length);
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(naslov);
            Console.ResetColor();
            NaglasiNaslov(naslov.Length);

        }
        private static void NaglasiNaslov(int komada)
        {

            for (int i = 0; i < komada; i++)
            {
                Console.Write("-");

            }
            Console.WriteLine();
        }

        /*

    Zimski zadaci:

    Jednostavni
    1. Izračun površine pravokutnika:
    Napiši program koji od korisnika traži da unese duljinu i širinu pravokutnika, a zatim izračunava i ispisuje površinu pravokutnika.
    2. Provjera je li broj pozitivan, negativan ili nula:
    Napiši program koji od korisnika traži da unese broj i ispisuje je li broj pozitivan, negativan ili nula.
    3. Zbroj elemenata niza:
    Napiši program koji deklarira niz cijelih brojeva, traži od korisnika da unese vrijednosti u niz, a zatim izračunava i ispisuje zbroj svih elemenata niza.
    4. Prosjek ocjena:
    Napiši program koji od korisnika traži da unese broj ocjena, a zatim i same ocjene. Program treba izračunati i ispisati prosjek ocjena.
    5. Ispis Fibonaccijevog niza:
    Napiši program koji od korisnika traži da unese broj n, a zatim ispisuje prvih n brojeva Fibonaccijevog niza (0, 1, 1, 2, 3, 5, 8...).
    6. Preokret stringa:
    Napiši program koji od korisnika traži da unese string, a zatim ispisuje taj string naopako (npr. "zdravo" postaje "ovardz").
    7. Brojanje samoglasnika:
    Napiši program koji od korisnika traži da unese string, a zatim prebrojava i ispisuje koliko samoglasnika ima u tom stringu.
    8. Pretvorba temperature:
    Napiši program koji od korisnika traži da unese temperaturu u Celzijusima i pretvara je u Fahrenheit (°F = °C * 9/5 + 32) ili obrnuto, ovisno o odabiru korisnika.
    9. Sortiranje niza:
    Napiši program koji deklarira niz cijelih brojeva, traži od korisnika da unese vrijednosti u niz, a zatim sortira niz uzlazno i ispisuje sortirani niz.
    10. Kalkulator:
    Napiši program koji od korisnika traži da unese dva broja i operaciju (+, -, *, /), a zatim izračunava i ispisuje rezultat. Koristi switch statement za odabir operacije.


    Generator lozinki
    Program od korisnika traži unos podataka:
    Dužina lozinke
    Uključena/isključena velika slova
    Uključena/isključena mala slova
    Uključeni/isključeni brojevi
    Uključeni/isključeni interpunkcijski znakovi
    Lozinka počinje ili ne s brojem
    Lozinka počinje ili ne s interpunkcijskim znakom
    Lozinka završava ili ne s brojem
    Lozinka završava ili ne s interpunkcijskim znakom
    Lozinka ima/nema ponavljajuće znakove
    Broj lozinki koje je potrebno generirati

    Shodno unesenim pravilima program generira rezultat (jedna ili više lozinki)


    Ciklična matrica
    Napraviti osnovni zadatak prema inicijalnoj slici
    Dodatno:
    Osigurati unos brojeva redova i kolona u rasponu 2 do 50
    Napraviti da nakon završetka generiranja jedne matrice pita želite li napraviti još jednu i tako sve dok ne unese NE
    Napraviti opcije programa o smjeru kretanja brojeva:
    1. dolje desno početak u smjeru kazaljke na satu (inicijalni zadatak)
    2. dolje lijevo početak u smjeru kazaljke na satu
    3. gore lijevo početak u smjeru kazaljke na satu
    4. gore desno početak u smjeru kazaljke na satu

    5. dolje desno početak u kontra smjeru kazaljke na satu 
    6. dolje lijevo početak u kontra smjeru kazaljke na satu
    7. gore lijevo početak u kontra smjeru kazaljke na satu
    8. gore desno početak u kontra smjeru kazaljke na satu

    19. sredina (ono što je bio kraj u prvih 8 primjera) lijevo u smjeru kazaljke na satu
    10. sredina (ono što je bio kraj u prvih 8 primjera) desno u smjeru kazaljke na satu
    11. sredina (ono što je bio kraj u prvih 8 primjera) gore u smjeru kazaljke na satu
    12. sredina (ono što je bio kraj u prvih 8 primjera) dolje u smjeru kazaljke na satu

    13. sredina (ono što je bio kraj u prvih 8 primjera) lijevo u kontra smjeru kazaljke na satu
    14. sredina (ono što je bio kraj u prvih 8 primjera) desno u kontra smjeru kazaljke na satu
    15. sredina (ono što je bio kraj u prvih 8 primjera) gore u kontra smjeru kazaljke na satu
    16. sredina (ono što je bio kraj u prvih 8 primjera) dolje u kontra smjeru kazaljke na satu

    Formatirati brojeve da budu potpisati po pravilima matematike: jedinica ispod jedinice, desetica ispod desetice, stotica ispod stotice






    Ljubavni kalkulator
    Napraviti osnovni zadatak prema inicijalnoj slici koristeći rekurziju
    Dodatno:
    Osigurati unos imena (smije imati samo slova, bez brojeva i interpunkcijskih znakova)
    promijeniti algoritam da zbraja dva susjedna broja (1 i 2, 3 i 4, 5 i 6, itd.) umjesto osnovnog algoritma 1 i zadnji, drugi i predzadnji itd.
    Umjesto rekurzije koristiti petlju po izboru









    Kada završite sve zadatke s svim opcijama javite se na email pa ću poslati nove :)






    */



    }
}

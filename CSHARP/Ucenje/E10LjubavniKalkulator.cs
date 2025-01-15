using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Ucenje
{
    internal class E10LjubavniKalkulator
    {

        /*Ljubavni kalkulator
    Napraviti osnovni zadatak prema inicijalnoj slici koristeći rekurziju

    Dodatno:
            Osigurati unos imena(smije imati samo slova, bez brojeva i interpunkcijskih znakova)
    promijeniti algoritam da zbraja dva susjedna broja(1 i 2, 3 i 4, 5 i 6, itd.) umjesto osnovnog algoritma 1 i zadnji, drugi i predzadnji itd.
    Umjesto rekurzije koristiti petlju po izboru*/

        public static void Izvedi()
        {
            char srce = '\u2665';
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{srce}{srce}{srce} DOBRO DOŠLI U LJUBAVNI KALKULATOR! {srce}{srce}{srce}");
            Console.ResetColor();
            Console.WriteLine();
            Izbornik();


        }

        private static void Izbornik()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("IZBORNIK");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("1. Ljubavni kalkulator (rubno zbrajanje)");
            Console.WriteLine("2. Ljubavni kalkulator (susjedno zbrajanje)");
            Console.WriteLine();
            OdaberiOpciju();

        }

        private static void OdaberiOpciju()
        {
            bool izlaz = false;
            while (!izlaz)
            {
                int opcija = E12Metode.UcitajCijeliBroj("Odaberi opciju 1 ili 2 (0 za izlaz): ");
                Console.WriteLine();
                if (opcija > 2)
                {
                    Console.WriteLine("Nepostojeća opcija, pokušajte ponovno!");
                    Console.WriteLine();
                    Izbornik();
                }
                else if (opcija == 0)
                {
                    Console.WriteLine("Hvala na korištenju Ljubavnog kalkulatora!");
                    izlaz = true;
                    break;
                }

                else
                {

                    string ime1 = E12Metode.UcitajString("Unesi svoje ime: ").ToUpper();
                    if (!SamoSlova(ime1))
                    {
                        Console.WriteLine("Greška! Dozvoljena su samo slova, pokušajte ponovno!");
                        Console.WriteLine();
                        Izbornik();
                    }
                    string ime2 = E12Metode.UcitajString("Unesi ime svoje simpatije: ").ToUpper();

                    if (!SamoSlova(ime2))
                    {
                        Console.WriteLine("Greška! Dozvoljena su samo slova, pokušajte ponovno!");
                        Console.WriteLine();
                        Izbornik();
                    }

                    char[] imena = (ime1 + ime2).ToCharArray();

                    Dictionary<char, int> brojac = new Dictionary<char, int>();

                    foreach (char slovo in imena)
                    {
                        if (brojac.ContainsKey(slovo))
                        {
                            brojac[slovo]++;
                        }
                        else
                        {
                            brojac[slovo] = 1;
                        }

                    }

                    int[] imenabrojevi = new int[imena.Length];
                    int indeks = 0;
                    foreach (char znak in imena)
                    {
                        int broj = brojac.FirstOrDefault(par => par.Key == znak).Value;

                        // Dodaj vrijednost u niz
                        imenabrojevi[indeks] = broj;
                        indeks++;
                    }

                    Console.WriteLine(string.Join("", imenabrojevi));

                    switch (opcija)
                    {
                        case 1:
                            Console.WriteLine();
                            LjubavniKalkulator1(imenabrojevi, ime1, ime2);
                            Console.WriteLine();
                            Izbornik();
                            break;
                        case 2:
                            Console.WriteLine();
                            LjubavniKalkulator2(imenabrojevi, ime1, ime2);
                            Console.WriteLine();
                            Izbornik();
                            break;
                        default:
                            Console.WriteLine("Ostalo");
                            break;

                    }

                }
                break;

            }
        }

        private static bool SamoSlova(string unos) //osigurava da je string slova
        {
            foreach (char znak in unos)
            {
                if (!char.IsLetter(znak))
                {
                    return false;
                }
            }

            return true; // Ako su svi znakovi slova, vraća true
        }

        private static void LjubavniKalkulator2(int[] imenabrojevi, string ime1, string ime2)
        {
            char srce = '\u2665';
            string rezultat = ZbrojiSusjedneZnamenke(imenabrojevi);
            Console.ForegroundColor = ConsoleColor.Red;
            if (int.Parse(rezultat) <= 25)
                Console.WriteLine("{0} i {1} imaju ljubavni rezultat {2}%. Nažalost, vi niste jedno za drugo :(", ime1, ime2, rezultat);
            else if (int.Parse(rezultat) > 25 && int.Parse(rezultat) <= 50)
                Console.WriteLine("{0} i {1} imaju ljubavni rezultat {2}%. Hm, možda ipak možeš naći nekog boljeg?", ime1, ime2, rezultat);
            else if (int.Parse(rezultat) > 50 && int.Parse(rezultat) <= 75)
                Console.WriteLine("{0} i {1} imaju ljubavni rezultat {2}%. Ova kombinacija ima potencijala, samo naprijed!", ime1, ime2, rezultat);
            else
                Console.WriteLine("{0} i {1} imaju ljubavni rezultat {2}%. Pa ovo je prava ljubav, čestitamo!", ime1, ime2, rezultat);

            for (int i = 1; i <= int.Parse(rezultat); i++)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{srce}");// {srce} {srce} {srce} {srce} {srce} {srce} {srce} {srce} {srce} {srce} {srce}");
                Console.ResetColor();

            }
            Console.WriteLine();


        }

        private static string ZbrojiSusjedneZnamenke(int[] broj)
        {
            List<int> rezultati = new List<int>(broj);

            while (rezultati.Count > 2)
            {
                List<int> noviRezultati = new List<int>();

                for (int i = 0; i < rezultati.Count; i += 2)
                {
                    if (i + 1 < rezultati.Count) // Provjera da index ne ode out of range
                    {
                        int sum = rezultati[i] + rezultati[i + 1];
                        noviRezultati.Add(sum);
                    }

                }
                //ako je neparan broj znamenki, samo se dodaje posljednja znamenka
                if (rezultati.Count % 2 != 0)
                {
                    noviRezultati.Add(rezultati.Last());
                }
                rezultati = noviRezultati;



            }

            string rezultat = string.Join("", rezultati);
            Console.WriteLine(rezultat);

            if (int.Parse(rezultat) >= 100)
            {
                do
                {
                    int a = (rezultat[0] - '0') + (rezultat[1] - '0');
                    int b = rezultat[2] - '0';
                    rezultat = string.Concat("", a, b);
                } while (int.Parse(rezultat) > 100);


            }
            return rezultat;

        }

        private static void LjubavniKalkulator1(int[] imenabrojevi, string ime1, string ime2)
        {
            //Osnovni zadatak - rekurzija
            char srce = '\u2665';
            string rezultat = ZbrojiZnamenke(imenabrojevi);
            Console.ForegroundColor = ConsoleColor.Red;
            if (int.Parse(rezultat) <= 25)
                Console.WriteLine("{0} i {1} imaju ljubavni rezultat {2}%. Nažalost, vi niste jedno za drugo :(", ime1, ime2, rezultat);
            else if (int.Parse(rezultat) > 25 && int.Parse(rezultat) <= 50)
                Console.WriteLine("{0} i {1} imaju ljubavni rezultat {2}%. Hm, možda ipak možeš naći nekog boljeg?", ime1, ime2, rezultat);
            else if (int.Parse(rezultat) > 50 && int.Parse(rezultat) <= 75)
                Console.WriteLine("{0} i {1} imaju ljubavni rezultat {2}%. Ova kombinacija ima potencijala, samo naprijed!", ime1, ime2, rezultat);
            else
                Console.WriteLine("{0} i {1} imaju ljubavni rezultat {2}%. Pa ovo je prava ljubav, čestitamo! <3", ime1, ime2, rezultat);

            for (int i = 1; i <= int.Parse(rezultat); i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{srce}");// {srce} {srce} {srce} {srce} {srce} {srce} {srce} {srce} {srce} {srce} {srce}");
                Console.ResetColor();

            }
            Console.WriteLine();

        }


        private static string ZbrojiZnamenke(int[] broj)
        {


            if (broj.Length <= 1)
            {
                return string.Join("", broj);
            }


            int prvi = broj[0];
            int zadnji = broj[broj.Length - 1];
            int sum = prvi + zadnji;

            int[] sredina = new int[broj.Length - 2];
            Array.Copy(broj, 1, sredina, 0, broj.Length - 2);
            string rezultatSredine = ZbrojiZnamenke(sredina);
            string rezultat = sum.ToString() + rezultatSredine;
            if (rezultat.Length > 2)
            {
                return ZbrojiZnamenke(stringUBroj(rezultat));
            }
            return rezultat;

        }

        private static int[] stringUBroj(string broj)
        {
            int[] brojevi = new int[broj.Length];
            for (int i = 0; i < broj.Length; i++)
            {
                brojevi[i] = int.Parse(broj[i].ToString());  // Pretvaranje char u int može i ovako: - '0'(ASCII kod)
            }
            return brojevi;
        }

    }
}

    






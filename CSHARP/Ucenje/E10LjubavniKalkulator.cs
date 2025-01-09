using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine("Dobro došli u Ljubavni kalkulator!");
            Console.WriteLine();
            Console.WriteLine("IZBORNIK");
            Console.WriteLine();
            Console.WriteLine("1. Ljubavni kalkulator (rubno zbrajanje)");
            Console.WriteLine("2. Fibonaccijev ljubavni kalkulator");
            Console.WriteLine();

            bool izlaz = false;
            while (!izlaz)
            {
                int opcija = E12Metode.UcitajCijeliBroj("Odaberi opciju 1 ili 2 (0 za izlaz): ");
                Console.WriteLine();
                if (opcija == 0)
                {
                    Console.WriteLine("Hvala na korištenju Ljubavnog kalkulatora!");
                    izlaz = true;
                    break;
                }
                else
                {
                    string ime1 = E12Metode.UcitajString("Unesi svoje ime: ").ToUpper();
                    string ime2 = E12Metode.UcitajString("Unesi ime svoje simpatije: ").ToUpper();
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


                    for (int i = 0; i < imena.Length; i++)
                    {
                        imenabrojevi[i] = brojac[imena[i]];
                    }


                    switch (opcija)
                    {
                        case 1:
                            Console.WriteLine();
                            LjubavniKalkulator1(imenabrojevi, ime1, ime2);
                            Console.WriteLine();
                            Izvedi();
                            break;
                        case 2:
                            Console.WriteLine();
                            Console.WriteLine();
                            Izvedi();
                            break;

                    }

                }

            }
        }

        private static void LjubavniKalkulator1(int[] imenabrojevi, string ime1, string ime2)
        {
            //Osnovni zadatak - rekurzija
            string rezultat = ZbrojiZnamenke(imenabrojevi);
            if (int.Parse(rezultat) <= 25)
                Console.WriteLine("{0} i {1} imaju ljubavni rezultat {2}%. Nažalost, vi niste jedno za drugo :(", ime1, ime2, rezultat);
            else if (int.Parse(rezultat) > 25 && int.Parse(rezultat) <= 50)
                Console.WriteLine("{0} i {1} imaju ljubavni rezultat {2}%. Hm, možda ipak možeš naći nekog boljeg?", ime1, ime2, rezultat);
            else if (int.Parse(rezultat) > 50 && int.Parse(rezultat) <= 75)
                Console.WriteLine("{0} i {1} imaju ljubavni rezultat {2}%. Ova kombinacija ima potencijala, samo naprijed!", ime1, ime2, rezultat);
            else
                Console.WriteLine("{0} i {1} imaju ljubavni rezultat {2}%. Pa ovo je prava ljubav, čestitamo! <3", ime1, ime2, rezultat);

        }

        private static string ZbrojiZnamenke(int[] broj)
        {
            //ako je broj znamenki 0-2, vraća taj broj
            if (broj.Length <= 1)
            {
                return string.Join("", broj);
            }
            int prvi = broj[0];
            int zadnji = broj[broj.Length - 1];
            int sum = prvi + zadnji;

            int[] sredina = new int[broj.Length - 2];// minus 2 zato što oduzima prvi i zadnji
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


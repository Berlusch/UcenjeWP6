using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E100LjubavniKalkulatorObostranaLjubav
    {

        public static void Izvedi()
        {

            char srce = '\u2665';
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{srce}{srce}{srce} DOBRO DOŠLI U LJUBAVNI KALKULATOR (obostrana ljubav)! {srce}{srce}{srce}");
            Console.ResetColor();
            Console.WriteLine();
            Unos();
            Console.WriteLine();
            Console.WriteLine("Hvala na korištenju programa Ciklična tablica, doviđenja!");


        }

        private static void Unos()
        {
            string ime1 = E12Metode.UcitajString("Unesi svoje ime: ").ToUpper();
            if (!SamoSlova(ime1))
            {
                Console.WriteLine("Greška! Dozvoljena su samo slova, pokušajte ponovno!");
                Console.WriteLine();
                Unos();
            }
            string ime2 = E12Metode.UcitajString("Unesi ime svoje simpatije: ").ToUpper();

            if (!SamoSlova(ime2))
            {
                Console.WriteLine("Greška! Dozvoljena su samo slova, pokušajte ponovno!");
                Console.WriteLine();
                Unos();
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
            var imenaAbecedno = imena.OrderBy(slovo => slovo).ToArray();

            int[] imenabrojevi = new int[imena.Length];
            int indeks = 0;
            foreach (char znak in imenaAbecedno)
            {
                int broj = brojac.FirstOrDefault(par => par.Key == znak).Value;

                // Dodaj vrijednost u niz
                imenabrojevi[indeks] = broj;
                indeks++;
            }
            LjubavniKalkulator(imenabrojevi, ime1, ime2);
            Console.WriteLine();
            Nastavak();
        }


        private static void LjubavniKalkulator(int[] imenabrojevi, string ime1, string ime2)
        {
            char srce = '\u2665';
            string rezultat = ZbrojiZnamenke(imenabrojevi);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{0} i {1} imaju ljubavni rezultat {2}%.", ime1, ime2, rezultat);

            for (int i = 1; i <= int.Parse(rezultat); i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{srce}");// {srce} {srce} {srce} {srce} {srce} {srce} {srce} {srce} {srce} {srce} {srce}");
                Console.ResetColor();

            }
            Console.WriteLine();

        }



        private static bool Nastavak()
        {
            bool nastavak = E12Metode.UcitajBool("Želite li nastaviti? ", "da");
            while (nastavak)
            {
                Console.WriteLine();
                Unos();
                return true;
            }
            return false;

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










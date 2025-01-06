using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E10GeneratorLozinki
    {
        /*Generator lozinki
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

        Shodno unesenim pravilima program generira rezultat(jedna ili više lozinki)
        */
        public static void Izvedi()
        {
            bool prvoInterpunkcija = false;
            bool zadnjeInterpunkcija = false;
            Console.WriteLine("Dobro došli u Generator lozinki! Molimo da odaberete sljedeće opcije: ");
            int duzinaLozinke = E12Metode.UcitajCijeliBroj("Dužina lozinke (unesite željeni broj znakova): ");
            int brojLozinki = E12Metode.UcitajCijeliBroj("Upišite željeni broj lozinki: ");
            bool velikaSlova = E12Metode.UcitajBool("Uključena velika slova (DA ili NE): ", "DA");
            bool malaSlova = E12Metode.UcitajBool("Uključena mala slova (DA ili NE): ", "DA");
            bool brojevi = E12Metode.UcitajBool("Uključeni brojevi (DA ili NE): ", "DA");
            bool interpunkcija = E12Metode.UcitajBool("Uključeni interpunkcijski znakovi (DA ili NE): ", "DA");
            bool prvoBroj = E12Metode.UcitajBool("Lozinka započinje brojem (DA ili NE): ", "DA");
            if (!prvoBroj)
            {
                prvoInterpunkcija = E12Metode.UcitajBool("Lozinka započinje interpunkcijskim znakom (DA ili NE): ", "DA");
            }
            else
            {

            }
            bool zadnjeBroj = E12Metode.UcitajBool("Lozinka završava brojem (DA ili NE): ", "DA");
            if (!zadnjeBroj)
            {
                zadnjeInterpunkcija = E12Metode.UcitajBool("Lozinka završava interpunkcijskim znakom (DA ili NE): ", "DA");
            }
            else
            {

            }
            bool ponavljanjeZnakova = E12Metode.UcitajBool("Ponavljajući znakovi (DA ili NE): ", "DA");


            string znakovi = SkupOdabranihZnakova(velikaSlova, malaSlova, brojevi, interpunkcija);

            for (int i = 0; i < brojLozinki; i++)
            {
                string lozinka = GenerirajLozinku(duzinaLozinke, znakovi, prvoBroj, prvoInterpunkcija, zadnjeBroj, zadnjeInterpunkcija);
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine($"{i + 1}. lozinka: {lozinka}");
                Console.ResetColor();

            }


        }


        private static string SkupOdabranihZnakova(bool velikaSlova, bool malaSlova, bool brojevi, bool interpunkcija)
        {
            string znakovi = "";
            if (velikaSlova)
            {
                znakovi += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            }
            if (malaSlova)
            {
                znakovi += "abcdefghijklmnopqrstuvwxyz";
            }
            if (brojevi)
            {
                znakovi += "0123456789";
            }
            if (interpunkcija)
            {
                znakovi += "!@#$%^&*()_+-=[]{}|;:,.<>?";
            }
            return znakovi;


        }

        private static string GenerirajLozinku(int duzinaLozinke, string znakovi, bool prvoBroj, bool prvoInterpunkcija, bool zadnjeBroj, bool zadnjeInterpunkcija)
        {
            Random random = new Random();
            char[] lozinka = new char[duzinaLozinke];

            //prvi znak
            if (prvoBroj)
            {
                char[] brojevi = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                lozinka[0] = brojevi[random.Next(brojevi.Length)];
            }
            else if (prvoInterpunkcija)
            {
                char[] interpunkcija = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '+', '-', '=', '[', ']', '{', '}', '|', ';', ':', ',', '.', '<', '>', '?' };
                lozinka[0] = interpunkcija[random.Next(interpunkcija.Length)];
            }
            else
            {
                char[] slova = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
                lozinka[0] = slova[random.Next(slova.Length)];
            }
            //zadnji znak
            if (zadnjeBroj)
            {
                char[] brojevi = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                lozinka[duzinaLozinke - 1] = brojevi[random.Next(brojevi.Length)];
            }
            else if (zadnjeInterpunkcija)
            {
                char[] interpunkcija = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '+', '-', '=', '[', ']', '{', '}', '|', ';', ':', ',', '.', '<', '>', '?' };
                lozinka[duzinaLozinke - 1] = interpunkcija[random.Next(interpunkcija.Length)];
            }
            else
            {
                char[] slova = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
                lozinka[duzinaLozinke - 1] = slova[random.Next(slova.Length)];

            }
            for (int i = 1; i < duzinaLozinke-1; i++)
            {
                lozinka[i] = znakovi[random.Next(znakovi.Length)];
            }

            //  LOZINKA 
            return new string(lozinka);

        }


    }
}

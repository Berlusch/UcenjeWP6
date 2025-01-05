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
            Console.WriteLine("Dobro došli u Generator lozinki! Molimo da odaberete sljedeće opcije: ");
            int duzinaLozinke = E12Metode.UcitajCijeliBroj("Dužina lozinke (unesite željeni broj znakova): ");
            bool velikaSlova = E12Metode.UcitajBool("Uključena velika slova (DA ili NE): ", "DA");
            bool malaSlova = E12Metode.UcitajBool("Uključena mala slova (DA ili NE): ", "DA");
            bool brojevi = E12Metode.UcitajBool("Uključeni brojevi (DA ili NE: ", "DA");
            bool interpunkcija = E12Metode.UcitajBool("Uključeni interpunkcijski znakovi (DA ili NE): ", "DA");
            bool prvoBroj = E12Metode.UcitajBool("Lozinka započinje brojem (DA ili NE: ", "DA");
            if (!prvoBroj)
            {
                bool prvointerpunkcija = E12Metode.UcitajBool("Lozinka započinje interpunkcijskim znakom (DA ili NE): ", "DA");
            }
            else
            {

            }
            bool zadnjeBroj = E12Metode.UcitajBool("Lozinka završava brojem (DA ili NE): ", "DA");
            if (!zadnjeBroj)
            {
                bool zadnjeInterpunkcija = E12Metode.UcitajBool("Lozinka završava interpunkcijskim znakom (DA ili NE)", "DA");
            }
            else
            {

            }
            bool ponavljanjeZnakova = E12Metode.UcitajBool("Ponavljajući znakovi (DA ili NE): ", "DA");

            string lozinka = GenerirajLozinku();


        }
        private static string SkupOdabranihZnakova()
        {
            throw new NotImplementedException();
        }

        private static string GenerirajLozinku()
        {
            throw new NotImplementedException();
        }

    }
}

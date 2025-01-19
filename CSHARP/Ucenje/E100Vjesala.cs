using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E100Vjesala
    {
        public static void Izvedi()
        {

            Console.WriteLine("Dobro došli u igru Vješala!");
            Console.WriteLine();
            string[] popisRijeci = { "banana", "automobil", "zrakoplov", "eukaliptus", "kuhinja", "filozofija", "zgrada", "šalica",
                "programiranje","otorinolaringologija","pulover", "djevojčica" };
            Random random = new Random();
            string rijec = popisRijeci.OrderBy(r => random.Next()).First();  // Korištenje LINQ za slučajan odabir
            Console.WriteLine(rijec);
            Console.WriteLine();
            string[] zadatak = new string[rijec.Length];
            Console.WriteLine("ZADATAK: ");
            Console.WriteLine();
            for (int i = 0; i < rijec.Length; i++)
            {
                zadatak[i] = "_";
            }
            Console.WriteLine(string.Join(" ", zadatak));
            Console.WriteLine();
            PogodiSlovo(rijec, zadatak);
        }

        private static void PogodiSlovo(string rijec, string[] zadatak)
        {

            int promasaji = 0;
            string unos = E12Metode.UcitajString("Pogađajte slovo: ").ToLower();
            Console.WriteLine();
            char slovo = unos[0];
            if (char.IsLetter(slovo))
            {
                for (int i = 0; i < rijec.Length; i++)
                {
                    if (rijec[i] == slovo)
                    {
                        zadatak[i] = slovo.ToString();  // Zamjena donje crtice s pogodjenim slovom
                        promasaji = 0;
                        
                    }
                                     
                }
                 
                Console.WriteLine(string.Join(" ", zadatak));
                Console.WriteLine(promasaji);
                PogodiSlovo(rijec, zadatak);
            }
            else
            {
                Console.WriteLine("Niste unijeli slovo, pokušajte ponovno!");
                PogodiSlovo(rijec, zadatak);
            }

        }
    }
}

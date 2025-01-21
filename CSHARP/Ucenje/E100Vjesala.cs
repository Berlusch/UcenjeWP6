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
        public class Hangman
        {
            private static int promasaji = 0;
            
            public static void Izvedi()
            {

                Naslov();
                string rijec = OdaberiRijec();
                string[] zadatak = new string[rijec.Length];
                int promasaji = 0;
                Console.WriteLine("ZADATAK: ");
                Console.WriteLine();
                for (int i = 0; i < rijec.Length; i++)
                {
                    zadatak[i] = "_";
                }
                NacrtajVjesala(promasaji);
                Console.WriteLine(string.Join(" ", zadatak));
                Console.WriteLine();
                PogodiSlovo(rijec, zadatak);
                Nastavak();

            }

            private static void PogodiSlovo(string rijec, string[] zadatak)
            {

                Console.WriteLine();
                bool igraTraje = true;
                promasaji = 0;

                while (igraTraje)
                {

                    string unos = E12Metode.UcitajString("Pogađajte slovo: ").ToLower();
                    if (string.IsNullOrEmpty(unos))
                    {
                        Console.WriteLine("Morate unijeti barem jedno slovo!");
                        continue;
                    }
                    char slovo = unos[0];
                    bool pogodjenoSlovo = false;
                    


                    for (int i = 0; i < rijec.Length; i++)
                    {
                        if (rijec[i] == slovo)
                        {
                            zadatak[i] = slovo.ToString();
                            pogodjenoSlovo = true;
                        }

                    }
                    if (!pogodjenoSlovo)
                    {
                        Console.WriteLine("Slovo {0} nije u zadanoj riječi!", slovo);
                        promasaji++; // Povećava broj promašaja
                    }

                    NacrtajVjesala(promasaji);
                    Console.WriteLine(string.Join(" ", zadatak));

                    // Provjera ako je riječ pogodena
                    if (!string.Join("", zadatak).Contains("_"))
                    {
                        Console.WriteLine();
                        Console.WriteLine("Čestitamo! Pogodili ste riječ: {0}", rijec);
                        igraTraje = false; // Kraj igre kad je riječ pogodena

                    }

                    // Ako su promašaji dosegli 6, kraj igre
                    if (promasaji == 6)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Nažalost, niste uspjeli, ovo je kraj! Tražena riječ bila je {0}!", rijec);
                        igraTraje = false; // Prekida igru nakon 6 promašaja

                    }

                    Console.WriteLine();

                }
            }

            private static string OdaberiRijec()
            {
                string[] popisRijeci = { "banana", "automobil", "zrakoplov", "eukaliptus", "kuhinja", "filozofija", "zgrada", "šalica",
                "programiranje","otorinolaringologija","pulover", "djevojčica" };
                Random random = new Random();
                string rijec = popisRijeci.OrderBy(r => random.Next()).First();  // Korištenje LINQ za slučajan odabir
                //Console.WriteLine(rijec);
                return rijec;


            }

            private static void Naslov()
            {
                Console.WriteLine("===========================");
                Console.WriteLine("Dobro došli u igru Vješala!");
                Console.WriteLine("===========================");
                Console.WriteLine();
            }

            private static bool Nastavak()
            {
                bool nastavak = E12Metode.UcitajBool("Želite li nastaviti? ", "da");
                if (nastavak)
                {

                    Console.WriteLine();
                    Izvedi();
                    return true;

                }
                else
                {

                    Console.WriteLine();
                    Console.WriteLine("Hvala što ste igrali igru Vješala!");
                    return false;

                }
            }


            private static void NacrtajVjesala(int promasaji)
            {
                string vjesala = "";
                if (promasaji == 0)
                {

                    vjesala = @"
                            +--+
                            |  |
                               |
                               |
                               |
                               |
                           =====";

                }
                if (promasaji == 1)
                {
                    vjesala = @"
                            +--+
                            |  |
                            O  |
                               |
                               |
                               |
                           =====";
                }
                if (promasaji == 2)
                {
                    vjesala = @"
                            +--+
                            |  |
                            O  |
                            |  |
                               |
                               |
                           =====";
                }
                if (promasaji == 3)
                {
                    vjesala = @"
                            +--+
                            |  |
                            O  |
                           /|  |
                               |
                               |
                           =====";
                }
                if (promasaji == 4)
                {
                    vjesala = @"
                            +--+
                            |  |
                            O  |
                           /|\ |
                               |
                               |
                           =====";

                }
                if (promasaji == 5)
                {
                    vjesala = @"
                            +--+
                            |  |
                            O  |
                           /|\ |
                           /   |
                               |
                           =====";
                }
                if (promasaji == 6)
                {
                    vjesala = @"
                             +--+
                             |  |
                             O  |
                            /|\ |
                            / \ |
                                |
                            =====";

                }
                Console.WriteLine();
                Console.WriteLine(vjesala);
            }

        }

    }

}





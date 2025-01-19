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
                Console.WriteLine("===========================");
                Console.WriteLine("Dobro došli u igru Vješala!");
                Console.WriteLine("===========================");
                Console.WriteLine();
                string[] popisRijeci = { "banana", "automobil", "zrakoplov", "eukaliptus", "kuhinja", "filozofija", "zgrada", "šalica",
                "programiranje","otorinolaringologija","pulover", "djevojčica" };
                Random random = new Random();
                string rijec = popisRijeci.OrderBy(r => random.Next()).First();  // Korištenje LINQ za slučajan odabir
                //Console.WriteLine(rijec);
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
                bool igraTraje = true;
                while (igraTraje)
                {
                    string unos = E12Metode.UcitajString("Pogađajte slovo: ").ToLower();
                    char slovo = unos[0];
                    bool pogodjenoSlovo = false;


                    foreach (char c in rijec)
                    {
                        if (slovo == c)
                        {
                            for (int i = 0; i < rijec.Length; i++)
                            {
                                if (rijec[i] == slovo)
                                {
                                    zadatak[i] = slovo.ToString();
                                    pogodjenoSlovo = true;
                                }
                            }
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
                        Console.WriteLine("Nažalost, niste uspjeli, ovo je kraj! Tražena riječ je bila {0}!", rijec);
                        igraTraje = false; // Prekida igru nakon 6 promašaja

                    }

                    Console.WriteLine();

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





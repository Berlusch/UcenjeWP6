using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E14Vjezbanje

    //3. program Za dani cijeli broj između 20 i 50 ispiši koja mu je vrijednost jedinice
    //34 treba biti 4 primjer
    {

        public static void Izvedi()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Dobro došli u vježbanje petkom!");
            Console.ResetColor();
            Izbornik();
            Console.WriteLine("Hvala na korištenju, doviđenja!");

        }

        //ulaz broj: 5179487


        private static void Izbornik()
        {
            string[] programi =
            {
                "Parnost broja",
                "Tablica množenja",
                "Jedinična vrijednost",
                "Broj znakova naziva mjesta",
                "Zbroj znamenki broja",
                "Prebrojavanje broja znakova"
            };

            Console.WriteLine();
            Console.WriteLine("IZBORNIK");

            for (int i = 0; i < programi.Length; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, programi[i]);
            }

            Console.WriteLine("0. Izlaz iz programa");
            OdabirOpcijeIzbornika(programi.Length);
        }

        private static void OdabirOpcijeIzbornika(int BrojPrograma)
        {
            switch (E12Metode.UcitajCijeliBroj("Odaberi stavku izbornika: ", 0, BrojPrograma))
            {
                case 0:
                    break;
                case 1:
                    Console.WriteLine("Poziv zadatka 1. Parnost broja");
                    ParnostBroja();
                    Izbornik();
                    break;
                case 2:
                    TablicaMnozenja();
                    Izbornik();
                    break;
                case 3:
                    JedinicnaVrijednost();
                    Izbornik();
                    break;
                case 4:
                    BrojZnakovaNazivaMjesta();
                    Izbornik();
                    break;
                case 5:
                    ZbrojZnamenkiBroja();
                    Izbornik();
                    break;
                case 6:
                    PrebrojavanjeBrojaZnakova();
                    Izbornik();
                    break;
            }
        }
        private static void PrebrojavanjeBrojaZnakova()
        {
            NaslovPrograma("Prebrojavanje znakova u izrazu");

            string izraz = E12Metode.UcitajString("Unesi izraz: ").ToLower();

            //Danas pada snijeg ---vanjska petlja
            //Danas pada snijeg ---unutarnja petlja
            int[] niz = new int[izraz.Length];
            bool[] ispisi = new bool[izraz.Length];//njegove sve vrijednosti su false
            int b;
            for (int i = 0; i < izraz.Length; i++)

            {
                b = 0;
                foreach (char c in izraz)

                {
                    if (izraz[i] == c)
                    {
                        b++;
                    }
                }
                niz[i] = b;
                //ako je b>1, tada treba samo na prvo pojavljivanje toga slova staviti true
                if (b > 1)
                {
                    for (int j = 0; j < izraz.Length; j++)
                    {
                        if (izraz[i] == izraz[j])
                        {
                            ispisi[j] = true;
                            break;
                        }
                    }
                }
                //inače na to slovo stavi true
                else
                {
                    ispisi[i] = true;
                }


            }
            //Console.WriteLine(string.Join(",", niz);
            for (int i = 0; i < niz.Length; i++)
            {
                if (ispisi[i] && izraz[i] != ' ')
                {
                    Console.WriteLine("{0}: ({1}) ", izraz[i], niz[i]);
                }

            }


        }



    


    private static void BrojZnakovaNazivaMjesta()
    {
        NaslovPrograma("Za uneseni naziv mjesta ispisuje koliko ima znakova");
        string ime = E12Metode.UcitajString("Unesi ime grada: ");
        Console.WriteLine(ime.Length);
    }

    private static void TablicaMnozenja()
    {
        NaslovPrograma("Program koji za dane brojeve redaka i stupaca generira tablicu množenja");
        int redaka = E12Metode.UcitajCijeliBroj("Unesi broj redaka: ", 2, 10);
        int stupaca = E12Metode.UcitajCijeliBroj("Unesi broj stupaca: ", 2, 10);

        for (int i = 1; i <= redaka; i++)
        {
            for (int j = 1; j <= stupaca; j++)
            {
                Console.Write("{0,4}", i * j + " ");
            }
            Console.WriteLine();
        }


    }

    private static void ParnostBroja()
    {
        NaslovPrograma("Program koji provjerava je li uneseni broj paran ili ne");
        int broj = E12Metode.UcitajCijeliBroj("Unesi cijeli broj: ");
        if (broj % 2 == 0)
        {
            Console.WriteLine("Uneseni broj {0} je paran", broj);

        }
        else Console.WriteLine("Uneseni broj {0} je neparan", broj);
    }
    private static void NaslovPrograma(string naslov)
    {
        //Console.WriteLine("***************");
        NaglasiNaslov(naslov.Length);
        Console.WriteLine(naslov);
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
    private static void JedinicnaVrijednost()
    {
        NaslovPrograma("Jedinicna vrijednost");
        int broj = E12Metode.UcitajCijeliBroj("Unesi broj između 20 i 50: ", 20, 50);
        int jed = broj % 10;
        {
            Console.WriteLine("Vrijednost jedinice je {0}", jed);
        }
    }
    private static void ZbrojZnamenkiBroja()
    {
        NaslovPrograma("Zbroj znamenki broja");
        string broj = E12Metode.UcitajString("Unesi cijeli broj: ");
        int manjiOd = E12Metode.UcitajCijeliBroj("Zbroj mora biti manji od: ");

        if (!provjeraBrojaURedu(broj))
        {
            Console.WriteLine("Nije dobar broj");
            return;//short circuiting
        }
        //mi smo sada sigurni da u našem stringu postoje samo znakovi koji su brojevi

        int rez = int.MaxValue;//(bolje je ne koristiti konstante)
        while (rez > manjiOd)
        {
            rez = 0;//(int)BigInteger.Zero;
            foreach (char c in broj)
            {
                rez += int.Parse(c.ToString());
            }
            //Console.WriteLine(rez);
            broj = rez.ToString();
        }
        Console.WriteLine(rez);
    }
    private static bool provjeraBrojaURedu(string broj)
    {
        foreach (char z in broj)
        {
            try
            {
                int.Parse(z.ToString());
            }
            catch
            {

                return false;
            }
        }
        return true;
    }
}
}

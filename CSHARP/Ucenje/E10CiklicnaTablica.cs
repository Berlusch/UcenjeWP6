using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E10CiklicnaTablica
    {

        /*Ciklična matrica
    Napraviti osnovni zadatak prema inicijalnoj slici
    Dodatno:
    Osigurati unos brojeva redova i kolona u rasponu 2 do 50
    Napraviti da nakon završetka generiranja jedne matrice pita želite li napraviti još jednu i tako sve dok ne unese NE
    Napraviti opcije programa o smjeru kretanja brojeva:
    1. dolje desno početak u smjeru kazaljke na satu(inicijalni zadatak)
    2. dolje lijevo početak u smjeru kazaljke na satu
    3. gore lijevo početak u smjeru kazaljke na satu
    4. gore desno početak u smjeru kazaljke na satu

    5. dolje desno početak u kontra smjeru kazaljke na satu 
    6. dolje lijevo početak u kontra smjeru kazaljke na satu
    7. gore lijevo početak u kontra smjeru kazaljke na satu
    8. gore desno početak u kontra smjeru kazaljke na satu

    19. sredina(ono što je bio kraj u prvih 8 primjera) lijevo u smjeru kazaljke na satu
    10. sredina(ono što je bio kraj u prvih 8 primjera) desno u smjeru kazaljke na satu
    11. sredina(ono što je bio kraj u prvih 8 primjera) gore u smjeru kazaljke na satu
    12. sredina(ono što je bio kraj u prvih 8 primjera) dolje u smjeru kazaljke na satu

    13. sredina(ono što je bio kraj u prvih 8 primjera) lijevo u kontra smjeru kazaljke na satu
    14. sredina(ono što je bio kraj u prvih 8 primjera) desno u kontra smjeru kazaljke na satu
    15. sredina(ono što je bio kraj u prvih 8 primjera) gore u kontra smjeru kazaljke na satu
    16. sredina(ono što je bio kraj u prvih 8 primjera) dolje u kontra smjeru kazaljke na satu

    Formatirati brojeve da budu potpisani po pravilima matematike: jedinica ispod jedinice, desetica ispod desetice, stotica ispod stotice*/


        public static void Izvedi()
        {
            Console.WriteLine("Dobro došli u program Ciklična tablica!");
            Console.WriteLine();
            Izbornik();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hvala na korištenju programa Ciklična tablica, doviđenja!");
            Console.ResetColor();





            //Ispis tablice-----------------------------------------------------------------------



        }

        private static bool ProvjeraBrojeva(int redova, int kolona)
        {


            while (true)
            {
                try
                {

                    if (redova < 2 || redova > 50)
                    {
                        Console.WriteLine("Broj nije u dopuštenom rasponu, pokušajte ponovno!");
                        continue;

                    }


                }
                catch
                {
                    Console.WriteLine("Nisi unio cijeli broj!");
                }
                break;
            }

            while (true)
            {
                try
                {

                    if (kolona < 2 || kolona > 50)
                    {
                        Console.WriteLine("Broj nije u dopuštenom rasponu, pokušajte ponovno!");
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Nisi unio cijeli broj!");
                }

            }
            return true;

        }

        private static void Izbornik()
        {
            Console.WriteLine("Prvo odaberite broj redova i broj kolona:");
            Console.WriteLine();
            int redova = E12Metode.UcitajCijeliBroj("Unesi broj redova (2-50): ");
            int kolona = E12Metode.UcitajCijeliBroj("Unesi broj kolona (2-50): ");
            Console.WriteLine();
            Console.WriteLine("Sada iz izbornika odaberite opciju ciklične tablice:");
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("IZBORNIK");
            Console.ResetColor();


            string[] programi =
{
                "Osnovna ciklična tablica - dolje desno početak, u smjeru kazaljke na satu",
                "Dolje lijevo početak, u smjeru kazaljke na satu",
                "Gore lijevo početak, u smjeru kazaljke na satu",
                "Gore desno početak, u smjeru kazaljke na satu",
                "Dolje desno početak, u kontra smjeru kazaljke na satu",
                "Dolje lijevo početak, u kontra smjeru kazaljke na satu",
                "Gore lijevo početak, u kontra smjeru kazaljke na satu",
                "Gore desno početak, u kontra smjeru kazaljke na satu",
                "Sredina početak(zadnji broj), cilj donji desni ugao, u smjeru kazaljke na satu",
                "Sredina početak(zadnji broj), cilj gornji desni ugao, u smjeru kazaljke na satu"
                /*"Sredina početak(zadnji broj), cilj gornji desni ugao, u smjeru kazaljke na satu",
                "Sredina početak(zadnji broj), cilj gornji desni ugao, u smjeru kazaljke na satu",
                "Sredina početak(zadnji broj), cilj gornji desni ugao, u smjeru kazaljke na satu",
                "Sredina početak(zadnji broj), desno u kontra smjeru kazaljke na satu",
                "Sredina početak(zadnji broj), gore u kontra smjeru kazaljke na satu",
                "Sredina početak(zadnji broj), dolje u kontra smjeru kazaljke na satu"*/
            };

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < programi.Length; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, programi[i]);
            }
            Console.WriteLine();
            Console.WriteLine("0. Izlaz iz programa");
            Console.WriteLine();
            OdabirOpcijeIzbornika(programi.Length, redova, kolona);
            Console.WriteLine();

            Console.WriteLine();
            ProvjeraBrojeva(redova, kolona);


        }

        private static void OdabirOpcijeIzbornika(int BrojPrograma, int redova, int kolona)
        {
            int[,] tablica;
            Console.WriteLine();
            switch (E12Metode.UcitajCijeliBroj("Vaša odabrana opcija ciklične tablice (1-16, 0 za izlaz): ", 0, BrojPrograma))
            {
                case 0:
                    break;
                case 1:
                    tablica = OsnovnaCiklicnaTablica(redova, kolona);
                    IspisiTablicu(tablica);
                    break;
                case 2:
                    tablica = Tablica2(redova, kolona);
                    IspisiTablicu(tablica);
                    break;
                case 3:
                    tablica = Tablica3(redova, kolona);
                    IspisiTablicu(tablica);
                    break;
                case 4:
                    tablica = Tablica4(redova, kolona);
                    IspisiTablicu(tablica);
                    break;
                case 5:
                    tablica = Tablica5(redova, kolona);
                    IspisiTablicu(tablica);
                    break;
                case 6:
                    tablica = Tablica6(redova, kolona);
                    IspisiTablicu(tablica);
                    break;
                case 7:
                    tablica = Tablica7(redova, kolona);
                    IspisiTablicu(tablica);
                    break;
                case 8:
                    tablica = Tablica8(redova, kolona);
                    IspisiTablicu(tablica);
                    break;
                case 9:
                    tablica = Tablica9(redova, kolona);
                    IspisiTablicu(tablica);
                    break;
                case 10:
                    tablica = Tablica10(redova, kolona);
                    IspisiTablicu(tablica);
                    break;
                /*case 11:
                    tablica = Tablica10(redova, kolona);
                    IspisiTablicu(tablica);
                    break;
                case 12:
                    tablica = Tablica10(redova, kolona);
                    IspisiTablicu(tablica);
                    break;
                case 13:
                    tablica = Tablica10(redova, kolona);
                    IspisiTablicu(tablica);
                    break;
                case 14:
                    tablica = Tablica10(redova, kolona);
                    IspisiTablicu(tablica);
                    break;*/
                default:
                    Console.WriteLine("Nevažeći odabir!");
                    break;

            }

            Console.WriteLine();
            Nastavak();
        }


        private static bool Nastavak()
        {
            bool nastavak = E12Metode.UcitajBool("Želite li nastaviti? ", "da");
            if (nastavak)
            {
                Console.WriteLine();
                Izbornik();
                return true;
            }
            else
            {
                return false;
            }
        }

        // OSNOVNA CIKLIČNA TABLICA ---------------------------------------------------------
        private static int[,] OsnovnaCiklicnaTablica(int redova, int kolona)
        {
            int cilj = redova * kolona;
            int brojac = 1;
            int maxLijevo = 0;
            int maxGore = 0;
            int maxDesno = kolona - 1;
            int maxDolje = redova - 1;

            int[,] tablica = new int[redova, kolona];

            while (brojac <= cilj)
            {

                // Dolje desno prema lijevo------------------------------------------------------
                for (int i = maxDesno; i >= maxLijevo && brojac <= cilj; i--)
                    tablica[maxDolje, i] = brojac++;
                maxDolje--;


                // Lijevo dolje prema gore-------------------------------------------------------------
                for (int i = maxDolje; i >= maxGore && brojac <= cilj; i--)
                    tablica[i, maxLijevo] = brojac++;
                maxLijevo++;


                // Gore lijevo prema desno-----------------------------------------------------------
                for (int i = maxLijevo; i <= maxDesno && brojac <= cilj; i++)
                    tablica[maxGore, i] = brojac++;
                maxGore++;


                // Desno gore prema dolje----------------------------------------------------------------
                for (int i = maxGore; i <= maxDolje && brojac <= cilj; i++)
                    tablica[i, maxDesno] = brojac++;
                maxDesno--;

            }
            return tablica;


        }

        // TABLICA 2 ---------------------------------------------------------
        private static int[,] Tablica2(int redova, int kolona)
        {


            int cilj = redova * kolona;
            int brojac = 1;
            int maxLijevo = 0;
            int maxGore = 0;
            int maxDesno = kolona - 1;
            int maxDolje = redova - 1;

            int[,] tablica = new int[redova, kolona];

            while (brojac <= cilj)
            {

                // Lijevo dolje prema gore-------------------------------------------------------------
                for (int i = maxDolje; i >= maxGore && brojac <= cilj; i--)
                    tablica[i, maxLijevo] = brojac++;
                maxLijevo++;


                // Gore lijevo prema desno-----------------------------------------------------------
                for (int i = maxLijevo; i <= maxDesno && brojac <= cilj; i++)
                    tablica[maxGore, i] = brojac++;
                maxGore++;


                // Desno gore prema dolje----------------------------------------------------------------
                for (int i = maxGore; i <= maxDolje && brojac <= cilj; i++)
                    tablica[i, maxDesno] = brojac++;
                maxDesno--;

                // Dolje desno prema lijevo------------------------------------------------------
                for (int i = maxDesno; i >= maxLijevo && brojac <= cilj; i--)
                    tablica[maxDolje, i] = brojac++;
                maxDolje--;

            }
            return tablica;
        }

        // TABLICA 3 ---------------------------------------------------------
        private static int[,] Tablica3(int redova, int kolona)
        {


            int cilj = redova * kolona;
            int brojac = 1;
            int maxLijevo = 0;
            int maxGore = 0;
            int maxDesno = kolona - 1;
            int maxDolje = redova - 1;

            int[,] tablica = new int[redova, kolona];

            while (brojac <= cilj)
            {

                // Gore lijevo prema desno-----------------------------------------------------------
                for (int i = maxLijevo; i <= maxDesno && brojac <= cilj; i++)
                    tablica[maxGore, i] = brojac++;
                maxGore++;


                // Desno gore prema dolje----------------------------------------------------------------
                for (int i = maxGore; i <= maxDolje && brojac <= cilj; i++)
                    tablica[i, maxDesno] = brojac++;
                maxDesno--;

                // Dolje desno prema lijevo------------------------------------------------------
                for (int i = maxDesno; i >= maxLijevo && brojac <= cilj; i--)
                    tablica[maxDolje, i] = brojac++;
                maxDolje--;

                // Lijevo dolje prema gore-------------------------------------------------------------
                for (int i = maxDolje; i >= maxGore && brojac <= cilj; i--)
                    tablica[i, maxLijevo] = brojac++;
                maxLijevo++;

            }
            return tablica;
        }

        // TABLICA 4 ---------------------------------------------------------

        private static int[,] Tablica4(int redova, int kolona)
        {


            int cilj = redova * kolona;
            int brojac = 1;
            int maxLijevo = 0;
            int maxGore = 0;
            int maxDesno = kolona - 1;
            int maxDolje = redova - 1;

            int[,] tablica = new int[redova, kolona];

            while (brojac <= cilj)
            {
                // Desno gore prema dolje----------------------------------------------------------------
                for (int i = maxGore; i <= maxDolje && brojac <= cilj; i++)
                    tablica[i, maxDesno] = brojac++;
                maxDesno--;

                // Dolje desno prema lijevo------------------------------------------------------
                for (int i = maxDesno; i >= maxLijevo && brojac <= cilj; i--)
                    tablica[maxDolje, i] = brojac++;
                maxDolje--;

                // Lijevo dolje prema gore-------------------------------------------------------------
                for (int i = maxDolje; i >= maxGore && brojac <= cilj; i--)
                    tablica[i, maxLijevo] = brojac++;
                maxLijevo++;

                // Gore lijevo prema desno-----------------------------------------------------------
                for (int i = maxLijevo; i <= maxDesno && brojac <= cilj; i++)
                    tablica[maxGore, i] = brojac++;
                maxGore++;

            }
            return tablica;
        }

        // TABLICA 5 ---------------------------------------------------------

        private static int[,] Tablica5(int redova, int kolona)
        {


            int cilj = redova * kolona;
            int brojac = 1;
            int maxLijevo = 0;
            int maxGore = 0;
            int maxDesno = kolona - 1;
            int maxDolje = redova - 1;

            int[,] tablica = new int[redova, kolona];

            while (brojac <= cilj)
            {
                // Desno dolje prema gore----------------------------------------------------------------
                for (int i = maxDolje; i >= maxGore && brojac <= cilj; i--)
                    tablica[i, maxDesno] = brojac++;
                maxDesno--;


                // Gore desno prema lijevo------------------------------------------------------
                for (int i = maxDesno; i >= maxLijevo && brojac <= cilj; i--)
                    tablica[maxGore, i] = brojac++;
                maxGore++;


                // Lijevo gore prema dolje-------------------------------------------------------------
                for (int i = maxGore; i <= maxDolje && brojac <= cilj; i++)
                    tablica[i, maxLijevo] = brojac++;
                maxLijevo++;


                // Dolje lijevo prema desno-----------------------------------------------------------
                for (int i = maxLijevo; i <= maxDesno && brojac <= cilj; i++)
                    tablica[maxDolje, i] = brojac++;
                maxDolje--;

            }
            return tablica;
        }

        // TABLICA 6 ---------------------------------------------------------

        private static int[,] Tablica6(int redova, int kolona)
        {


            int cilj = redova * kolona;
            int brojac = 1;
            int maxLijevo = 0;
            int maxGore = 0;
            int maxDesno = kolona - 1;
            int maxDolje = redova - 1;

            int[,] tablica = new int[redova, kolona];

            while (brojac <= cilj)
            {
                // Gore desno prema lijevo------------------------------------------------------
                for (int i = maxDesno; i >= maxLijevo && brojac <= cilj; i--)
                    tablica[maxGore, i] = brojac++;
                maxGore++;


                // Lijevo gore prema dolje-------------------------------------------------------------
                for (int i = maxGore; i <= maxDolje && brojac <= cilj; i++)
                    tablica[i, maxLijevo] = brojac++;
                maxLijevo++;


                // Dolje lijevo prema desno-----------------------------------------------------------
                for (int i = maxLijevo; i <= maxDesno && brojac <= cilj; i++)
                    tablica[maxDolje, i] = brojac++;
                maxDolje--;

                // Desno dolje prema gore----------------------------------------------------------------
                for (int i = maxDolje; i >= maxGore && brojac <= cilj; i--)
                    tablica[i, maxDesno] = brojac++;
                maxDesno--;

            }
            return tablica;
        }

        // TABLICA 7 ---------------------------------------------------------

        private static int[,] Tablica7(int redova, int kolona)
        {


            int cilj = redova * kolona;
            int brojac = 1;
            int maxLijevo = 0;
            int maxGore = 0;
            int maxDesno = kolona - 1;
            int maxDolje = redova - 1;

            int[,] tablica = new int[redova, kolona];

            while (brojac <= cilj)
            {
                // Lijevo gore prema dolje-------------------------------------------------------------
                for (int i = maxGore; i <= maxDolje && brojac <= cilj; i++)
                    tablica[i, maxLijevo] = brojac++;
                maxLijevo++;


                // Dolje lijevo prema desno-----------------------------------------------------------
                for (int i = maxLijevo; i <= maxDesno && brojac <= cilj; i++)
                    tablica[maxDolje, i] = brojac++;
                maxDolje--;

                // Desno dolje prema gore----------------------------------------------------------------
                for (int i = maxDolje; i >= maxGore && brojac <= cilj; i--)
                    tablica[i, maxDesno] = brojac++;
                maxDesno--;

                // Gore desno prema lijevo------------------------------------------------------
                for (int i = maxDesno; i >= maxLijevo && brojac <= cilj; i--)
                    tablica[maxGore, i] = brojac++;
                maxGore++;

            }
            return tablica;
        }

        // TABLICA 8 ---------------------------------------------------------

        private static int[,] Tablica8(int redova, int kolona)
        {


            int cilj = redova * kolona;
            int brojac = 1;
            int maxLijevo = 0;
            int maxGore = 0;
            int maxDesno = kolona - 1;
            int maxDolje = redova - 1;

            int[,] tablica = new int[redova, kolona];

            while (brojac <= cilj)
            {
                // Dolje lijevo prema desno-----------------------------------------------------------
                for (int i = maxLijevo; i <= maxDesno && brojac <= cilj; i++)
                    tablica[maxDolje, i] = brojac++;
                maxDolje--;

                // Desno dolje prema gore----------------------------------------------------------------
                for (int i = maxDolje; i >= maxGore && brojac <= cilj; i--)
                    tablica[i, maxDesno] = brojac++;
                maxDesno--;

                // Gore desno prema lijevo------------------------------------------------------
                for (int i = maxDesno; i >= maxLijevo && brojac <= cilj; i--)
                    tablica[maxGore, i] = brojac++;
                maxGore++;

                // Lijevo gore prema dolje-------------------------------------------------------------
                for (int i = maxGore; i <= maxDolje && brojac <= cilj; i++)
                    tablica[i, maxLijevo] = brojac++;
                maxLijevo++;

            }
            return tablica;
        }

        // TABLICA 9 ---------------------------------------------------------
        // Sredina(ono što je bio kraj u prvih 8 primjera) lijevo u smjeru kazaljke na satu

        private static int[,] Tablica9(int redova, int kolona)
        {
            int cilj = 1;
            int brojac = redova * kolona;
            int maxLijevo = 0;
            int maxGore = 0;
            int maxDesno = kolona - 1;
            int maxDolje = redova - 1;

            int[,] tablica = new int[redova, kolona];

            while (brojac >= cilj)
            {
                // Desno dolje prema gore----------------------------------------------------------------
                for (int i = maxDolje; i >= maxGore && brojac >= cilj; i--)
                    tablica[i, maxDesno] = brojac--;
                maxDesno--;


                // Gore desno prema lijevo------------------------------------------------------
                for (int i = maxDesno; i >= maxLijevo && brojac >= cilj; i--)
                    tablica[maxGore, i] = brojac--;
                maxGore++;


                // Lijevo gore prema dolje-------------------------------------------------------------
                for (int i = maxGore; i <= maxDolje && brojac >= cilj; i++)
                    tablica[i, maxLijevo] = brojac--;
                maxLijevo++;


                // Dolje lijevo prema desno-----------------------------------------------------------
                for (int i = maxLijevo; i <= maxDesno && brojac >= cilj; i++)
                    tablica[maxDolje, i] = brojac--;
                maxDolje--;

            }
            return tablica;
        }

        //TABLICA 10--------------------------------------------------

        private static int[,] Tablica10(int redova, int kolona)
        {


            int cilj = 1;
            int brojac = redova * kolona;
            int maxLijevo = 0;
            int maxGore = 0;
            int maxDesno = kolona - 1;
            int maxDolje = redova - 1;

            int[,] tablica = new int[redova, kolona];

            while (brojac >= cilj)
            {
                // Gore desno prema lijevo------------------------------------------------------
                for (int i = maxDesno; i >= maxLijevo && brojac >= cilj; i--)
                    tablica[maxGore, i] = brojac--;
                maxGore++;


                // Lijevo gore prema dolje-------------------------------------------------------------
                for (int i = maxGore; i <= maxDolje && brojac >= cilj; i++)
                    tablica[i, maxLijevo] = brojac--;
                maxLijevo++;


                // Dolje lijevo prema desno-----------------------------------------------------------
                for (int i = maxLijevo; i <= maxDesno && brojac >= cilj; i++)
                    tablica[maxDolje, i] = brojac--;
                maxDolje--;

                // Desno dolje prema gore----------------------------------------------------------------
                for (int i = maxDolje; i >= maxGore && brojac >= cilj; i--)
                    tablica[i, maxDesno] = brojac--;
                maxDesno--;

            }
            return tablica;
        }

        // ISPIŠI TABLICU-----------------------------------------------------------------------------------------------------------------
        private static void IspisiTablicu(int[,] tablica)
        {
            ConsoleColor[] boje = { ConsoleColor.Red, ConsoleColor.Yellow, ConsoleColor.Green, ConsoleColor.Blue, ConsoleColor.Cyan, ConsoleColor.Magenta };
            Random random = new Random();
            Console.WriteLine();
            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {

                    {
                        Console.ForegroundColor = boje[random.Next(boje.Length)];
                        Console.Write("{0,5}", tablica[i, j] + "  ");
                        Thread.Sleep(100);
                    }

                }
                Console.WriteLine();
                Console.WriteLine();

            }
            Console.ResetColor();
        }
    }
}

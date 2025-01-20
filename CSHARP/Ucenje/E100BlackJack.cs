using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E100BlackJack
    {
        public static void Izvedi()
        {
            Naslov();
            PravilaIgre();


        }

        private static void PravilaIgre()
        {
            bool pravila = E12Metode.UcitajBool("Želite li upoznati pravila igre? (upišite 'da' za pravila ili 'ne' za izravan prelazak " +
                "na igru): ", "da");
            if (pravila)
                Console.WriteLine();
            {
                Console.WriteLine("PRAVILA IGRE");
                Console.WriteLine("------------");
                Console.WriteLine();
                Console.WriteLine("Blackjack ili ajnc popularna je kartaška igra čija osnovna verzija ima vrlo jednostavna pravila. " +
                    "Ajnc mogu igrati dva ili više igrača, a moguće je igrati i protiv računala. Koristi se špil od 52 karte. " +
                    "Vrijednost karata označenih brojevima je taj broj, dok 'veće' karte, odnosno karte s licima vrijede po 10 bodova. " +
                    "Izuzetak je as, koji može vrijediti 11 ili 1, ovisno o zbroju ostalih karata. " +
                    "Ako je zbroj 10 ili manje, as će vrijediti 11; ako je zbroj veći od 10, vrijednost asa bit će 1.");
                Console.WriteLine();
                Console.WriteLine("Cilj je postići zbroj karata jednak ili što bliži broju 21. Zbroj veći od 21 znači izgubljenu partiju.");
                Console.WriteLine();
                Console.WriteLine("Djelitelj, u ovom slučaju računalo, igraču dijeli dvije karte s licima okrenutima gore. Nakon toga sebi dijeli dvije karte, " +
                    "od kojih je jedna okrenuta prema dolje, a jedna prema gore. Igrač zatim odlučuje želi li dobiti još jednu kartu ili će zadržati ovaj" +
                    " trenutačni zbroj karata. Karte se dijele dok god to netko traži.");
                Console.WriteLine();
                Console.WriteLine("-------------------------------------------------------------------------------------------");
                bool igraTraje= E12Metode.UcitajBool("Uživajte u igri! Upišite 'da' za prelazak na igru (ili 0 za izlaz): ", "da");
                if (igraTraje)
                {
                    PodijeliKarte();
                }
                else
                {
                    igraTraje = false;
                }

            }
        }

        private static void PodijeliKarte()
        {
            throw new NotImplementedException();
        }

        private static void Naslov()
        {
            Console.WriteLine();
            Console.WriteLine("***********************************************");
            Console.WriteLine("\u2660 \u2665 \u2666 \u2663 Dobro došli u igru Blackjack! \u2660 \u2665 \u2666 \u2663");
            Console.WriteLine("***********************************************");

        }
    }
}

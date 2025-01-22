using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E100BlackJack
    {
        public static void Izvedi()
        {
            int userSum = 0;
            int computerSum = 0;
            bool gameOn = true;
            GameTitle();
            GameRules();
            int[] cards = [11, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10];
            List<int> userCards = new List<int>();
            List<int> computerCards = new List<int>();
            FirstDeal(cards, userCards, computerCards, userSum, computerSum, gameOn);
            DealAgain(userCards, computerCards, cards, ref userSum, ref computerSum, gameOn);
            CompareSum(ref computerSum, ref userSum, ref gameOn, userCards, computerCards, cards);


        }

        private static void GameRules()
        {
            bool pravila = E12Metode.UcitajBool("Želite li upoznati pravila igre? (upišite 'da' za pravila ili 'ne' za izravan prelazak " +
                "na igru): ", "da");
            if (pravila)

            {
                Console.WriteLine();
                Console.WriteLine("PRAVILA IGRE");
                Console.WriteLine("------------");
                Console.WriteLine();
                Console.WriteLine("Blackjack ili ajnc popularna je kartaška igra čija osnovna verzija ima vrlo jednostavna pravila. " +
                    "Ajnc mogu igrati dva ili više igrača, a igra se protiv djelitelja, u ovom slučaju protiv računala. Koristi se špil od 52 karte. " +
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
                Console.WriteLine("Uživajte u igri!");
                Console.WriteLine("-------------------------------------------------------------------------------------------");
                bool goOn = E12Metode.UcitajBool("Upišite 'da' za prelazak na igru (ili 0 za izlaz): ", "da");
                if (!goOn)
                {
                    Console.WriteLine();
                    Console.WriteLine("Hvala na korištenju programa!");
                }

            }

        }

        private static void FirstDeal(int[] cards, List<int> userCards, List<int> computerCards, int userSum, int computerSum, bool gameOn)
        {



            for (int i = 1; i <= 2; i++)
            {
                computerCards.Add(DealCards(cards));
                userCards.Add(DealCards(cards));
            }
            computerSum = computerCards.Sum();
            userSum = userCards.Sum();
            Console.WriteLine();
            Console.WriteLine("Jedna poznata karta djelitelja je {0}, a zbroj Vaših karata je {1}.", computerCards[0], userSum);


        }

        private static void DealAgain(List<int> userCards, List<int> computerCards, int[] cards, ref int userSum, ref int computerSum, bool gameOn)
        {
            bool goOn = E12Metode.UcitajBool("Želite li još jednu kartu? ('da' za ponovno dijeljenje, 'ne' za zadržavanje postojećih karata  ): ", "da");

            if (goOn)
            {
                // Dijeljenje nove karte korisniku
                int newCard = DealCards(cards);
                userCards.Add(newCard);
                userSum = userCards.Sum();

                Console.WriteLine("Nova karta korisnika: {0}", newCard);

                // Djelitelj povlači kartu ako je njegov zbroj manji od 17
                if (computerSum < 17)
                {
                    int dealerCard = DealCards(cards);
                    computerCards.Add(dealerCard);
                    computerSum = computerCards.Sum();

                    Console.WriteLine("Nova karta djelitelja: {0}", dealerCard);
                }
            }

            // Ispis trenutnog stanja
            Console.WriteLine("Trenutno stanje djelitelja: {0}", string.Join(",", computerCards));
            Console.WriteLine("Trenutno stanje korisnika: {0}", string.Join(",", userCards));
            Console.WriteLine("Zbroj korisnika: {0}, zbroj djelitelja: {1}", userSum, computerSum);


        }

        private static void CompareSum(ref int computerSum, ref int userSum, ref bool gameOn, List<int> userCards, List<int> computerCards, int[] cards)
        {
            if (userSum > 21)
            {
                if (computerSum <= 21)
                {
                    Console.WriteLine("\nVaš zbroj je veći od 21, a zbroj karata djelitelja je {0} - izgubili ste!", computerSum);
                }
                else
                {
                    Console.WriteLine("\nOboje ste prešli 21. Rezultat je neriješen!");
                }
                gameOn = false;
                return; // Završava metodu
            }

            if (computerSum > 21)
            {
                Console.WriteLine("\nVaš zbroj je {0}, a zbroj karata djelitelja je veći od 21 - pobijedili ste!", userSum);
                gameOn = false;
                return;
            }

            if (userSum == computerSum)
            {
                Console.WriteLine("\nVaš zbroj je {0}, a zbroj karata djelitelja je {1}. Rezultat je neriješen!", userSum, computerSum);
                gameOn = false;
                return;
            }

            // Ako još nema pobjednika, igra se nastavlja
            DealAgain(userCards, computerCards, cards, ref userSum, ref computerSum, gameOn);

            // Nakon dodatnih karata, odluči pobjednika
            if (userSum > computerSum)
            {
                Console.WriteLine("Vaš zbroj je {0}, a zbroj karata djelitelja je {1} - pobijedili ste!", userSum, computerSum);
            }
            else
            {
                Console.WriteLine("Vaš zbroj je {0}, a zbroj karata djelitelja je {1} - izgubili ste!", userSum, computerSum);
            }

            gameOn = false; // Završava igru
        }

        public static int DealCards(int[] cards)
        {

            Random random = new Random();
            int randomIndex = random.Next(cards.Length);
            int card = cards[randomIndex];
            return card;
        }

        private static void GameTitle()
        {
            Console.WriteLine();
            Console.WriteLine("***********************************************");
            Console.WriteLine("\u2660 \u2665 \u2666 \u2663 Dobro došli u igru Blackjack! \u2660 \u2665 \u2666 \u2663");
            Console.WriteLine("***********************************************");

        }
    }
}

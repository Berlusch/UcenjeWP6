using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ucenje.E20KonzolnaAplikacija;
using Ucenje.UdomiMeKonzolnaAplikacija.Model;


namespace Ucenje.UdomiMeKonzolnaAplikacija
{
    internal class Izbornik
    {

        public ObradaPas ObradaPas { get; set; }
        public ObradaUdomitelj ObradaUdomitelj { get; set; }
        public ObradaUpit ObradaUpit { get; set; }

        public Izbornik()
        {
            Pomocno.DEV = false;
            ObradaPas = new ObradaPas();
            ObradaUdomitelj = new ObradaUdomitelj();
            ObradaUpit = new ObradaUpit();
            UcitajPodatke();
            PozdravnaPoruka();
            PrikaziIzbornik();
        }

        private void UcitajPodatke()
        {
            string docPath = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
        "GitHub" // Dodaj podmapu GitHub
    );

            string filePath = Path.Combine(docPath, "psi.json");

            if (File.Exists(filePath))
            {
                using (StreamReader file = File.OpenText(filePath)) // Korištenje using za automatsko zatvaranje
                {
                    ObradaPas.Psi = JsonConvert.DeserializeObject<List<Pas>>(file.ReadToEnd());

                }
            }

        }
        public static bool PotvrdaUnosa()
        {
            Console.WriteLine("Želite li spremiti promjene? (da/ne)");
            string potvrdaUnosa = Console.ReadLine().ToLower();

            if (potvrdaUnosa == "da")
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("Podatci su spremljeni, hvala.");
                Console.WriteLine();

                return true;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Odustali ste od unosa.");
                Console.WriteLine("-------------------------------");
                return false;
            }
        }

        private void PrikaziIzbornik()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("GLAVNI IZBORNIK");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("1. Psi");
            Console.WriteLine("2. Udomitelji");
            Console.WriteLine("3. Upiti");
            Console.WriteLine("4. Izlaz iz programa");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
            
            switch (Pomocno.UcitajRasponBroja("Odaberite stavku izbornika", 1, 4))

            {
                
                case 1:
                    Console.Clear();
                    ObradaPas.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                case 2:
                    Console.Clear();
                    ObradaUdomitelj.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                /*case 3:
                    Console.Clear();
                    ObradaUpit.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;*/
                case 4:                    
                    SpremiPodatke();
                    Console.WriteLine("Hvala na korištenju aplikacije, doviđenja!");
                    break;
            }
        }

        public void SpremiPodatke()
        {
            
            if (!PotvrdaUnosa())
            {
                
                return;
            }

            // Ako je u DEV načinu rada, ne spremamo podatke
            if (Pomocno.DEV)
            {
                return;
            }

            
            string docPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "GitHub");

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "psi.json")))
            {
                outputFile.WriteLine(JsonConvert.SerializeObject(ObradaPas.Psi));
            }
        }

        private void PozdravnaPoruka()
        {
            string asciiPas = @"
  / \__
 (    @\___
 /         O                                
/   (_____/
/_____/   U";

string asciiPasZrcalno = @"
                        __ / \  
                    ___/@     ) 
                    O         \
                    \_____)   \
                    U   \_____\ 
";
            
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(asciiPas+asciiPasZrcalno);
            Console.WriteLine();                     
            Console.WriteLine("*********************************");
            Console.WriteLine("********* UDOMI ME **************");
            Console.WriteLine("*********************************");
            Console.ResetColor();   
            Console.WriteLine();
        }
    }
}

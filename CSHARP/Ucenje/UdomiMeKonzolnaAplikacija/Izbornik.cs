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
            Pomocno.DEV = true;
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

        private void PrikaziIzbornik()
        {
            Console.WriteLine("GLAVNI IZBORNIK");
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
                /*case 2:
                    Console.Clear();
                    ObradaUdomitelj.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                case 3:
                    Console.Clear();
                    ObradaUpit.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;*/
                case 4:
                    Console.WriteLine("Hvala na korištenju aplikacije, doviđenja!");
                    SpremiPodatke();
                    break;
            }
        }

        private void SpremiPodatke()
        {
            if (Pomocno.DEV)
            {
                return;
            }

            //Console.WriteLine(JsonConvert.SerializeObject(ObradaSmjer.Smjerovi));

            string docPath =
          Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "psi.json"));
            outputFile.WriteLine(JsonConvert.SerializeObject(ObradaPas.Psi));
            outputFile.Close();
        }

        private void PozdravnaPoruka()
        {
            Console.WriteLine("*********************************");
            Console.WriteLine("********* UDOMI ME **************");
            Console.WriteLine("*********************************");
        }
    }
}

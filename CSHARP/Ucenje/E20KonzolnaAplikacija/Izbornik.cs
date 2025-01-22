using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Ucenje.E20KonzolnaAplikacija.Model;

namespace Ucenje.E20KonzolnaAplikacija
{
    internal class Izbornik
    {

        public ObradaSmjer ObradaSmjer { get; set; }  
        public ObradaPolaznik ObradaPolaznik { get; set; } 
        public ObradaGrupa ObradaGrupa { get; set; } 

        public Izbornik() 
        {
            Pomocno.DEV = true;
            ObradaSmjer = new ObradaSmjer();
            ObradaPolaznik = new ObradaPolaznik();
            ObradaGrupa = new ObradaGrupa(this);
            UcitajPodatke();
            PozdravnaPoruka();
            PrikaziIzbornik();
        }

        private void UcitajPodatke()
        {
            string docPath =
         Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if(File.Exists(Path.Combine(docPath, "smjerovi.json")))
            {
                StreamReader file = File.OpenText(Path.Combine(docPath, "smjerovi.json"));
                ObradaSmjer.Smjerovi = JsonConvert.DeserializeObject<List<Smjer>>(file.ReadToEnd());
                file.Close();

            }

        }

        private void PrikaziIzbornik()
        {
            Console.WriteLine("Glavni izbornik");
            Console.WriteLine("1. Smjerovi");
            Console.WriteLine("2. Polaznici");
            Console.WriteLine("3. Grupe");
            Console.WriteLine("4. Izlaz iz programa");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
            
            switch(Pomocno.UcitajRasponBroja("Odaberite stavku izbornika", 1, 4))
            {
                case 1:
                    Console.Clear();
                    ObradaSmjer.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                case 2:
                    Console.Clear();
                    ObradaPolaznik.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                case 3:
                    Console.Clear();
                    ObradaGrupa.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
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

            StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "smjerovi.json"));
            outputFile.WriteLine(JsonConvert.SerializeObject(ObradaSmjer.Smjerovi));
            outputFile.Close();
        }

        private void PozdravnaPoruka()
        {
            Console.WriteLine("*********************************");
            Console.WriteLine("*** Edunova Console App v 1.0 ***");
            Console.WriteLine("*********************************");
        }
    }
}

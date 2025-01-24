using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.UdomiMeKonzolnaAplikacija.Model
{
    public class Pas : Entitet
    {
        public string Ime { get; set; } = "";
        public string BrojCipa { get; set; } = "";
        public string Pasmina { get; set; } = "";
        public DateTime Datum_Rodjenja { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public Spol SpolVrsta { get; set; }

        public enum Spol { M, Ž }

        [JsonConverter(typeof(StringEnumConverter))]
        public Velicina VelicinaPsa { get; set; }

        public enum Velicina
        {
            Veliki,
            Srednji,
            Mali
        }

        [JsonConverter(typeof(StringEnumConverter))]
        public Boja BojaPsa { get; set; }

        public enum Boja
        {
            Bijeli,
            Crni,
            Smeđi,
            Šareni
        }

        public string MojaPrica { get; set; } = "";
        public bool Kastracija { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public StatusEnum StatusOpis { get; set; }

        public enum StatusEnum
        {
            Udomljen,
            Rezerviran,
            Slobodan,
            PrivremeniSmjestaj
        }
        public DateTime? DatumPromjene { get; set; }



        public void MojaPricaUvod()
        {
            Console.WriteLine("Pozdrav! Zovem se {0}, rođen/a sam {1}. Uredno sam čipiran/a i cijepljen/a, a moj broj čipa je {2}. Udomi me!", Ime, Datum_Rodjenja, BrojCipa);
            Console.WriteLine();
            Console.WriteLine(MojaPrica);
        }

        /*public void DetaljiPsa()
        {
            Console.WriteLine(Ime, SpolVrsta);
            Console.WriteLine(BrojCipa);
            Console.WriteLine(Pasmina);
            Console.WriteLine(DatumRodjenja);
            Console.WriteLine(Pomocno.BoolToYesNo(Kastracija));
            Console.WriteLine(StatusOpis);

        }*/
        public static string GetDescription(Velicina velicina)
        {
            switch (velicina)
            {
                case Velicina.Veliki:
                    return ">25 kg";
                case Velicina.Srednji:
                    return "5-25 kg";
                case Velicina.Mali:
                    return "do 5 kg";
                default:
                    return "Nepoznata veličina";
            }
        }
    }
}

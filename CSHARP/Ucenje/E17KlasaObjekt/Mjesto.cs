namespace Ucenje.E17KlasaObjekt
{
    public class Mjesto
    {
        public string Naziv { get; set; } = "";
        public string PostanskiBroj { get; set; } = ""; // sada svojstvo nije null nego je prazno
        public Zupanija? Zupanija { get; set; }
    }
}
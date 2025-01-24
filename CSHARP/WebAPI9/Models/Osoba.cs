namespace WebAPI9.Models
{
    public class Osoba
    {

        public int Sifra { get; set; }
        public string? Ime { get; set; }
        public decimal Koeficijent { get; set; }
        public DateTime? DatumRodjenja { get; set; }
        public bool Aktivan { get; set; }
    }
}

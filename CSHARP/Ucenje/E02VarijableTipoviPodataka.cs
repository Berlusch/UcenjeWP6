namespace Ucenje
{
    internal class E02VarijableTipoviPodataka
    {


        public static void Izvedi()
        {

            //Console.WriteLine("Hello E02");

            // int - integer - cijeli broj

            // deklaracija varijable
            int i; // i je od increment


            Console.Write("Upiši broj: ");
            // dodjeljivanje vrijednosti
            // i = Console.ReadLine();  OVO NE RADI jer je desno string a lijevo int

            i=int.Parse(Console.ReadLine());

            // korištenje vrijednosti
            Console.WriteLine("Upisali ste {0}, i evo ga još jednom {1}", i,i);


            // bit - logička vrijednost

            bool LogickaVrijednost;

            Console.Write("Unesi True ili False: ");

            LogickaVrijednost = bool.Parse(Console.ReadLine());

            Console.WriteLine("Unijeli ste {0}", LogickaVrijednost);

            // float - decimalni broj

            Console.Write("Unesi broj (, za decimalni dio): ");

            Console.WriteLine(float.Parse(Console.ReadLine()));

            float broj = 3.14F; // zato što je to float


            Console.Write("Unesi ime: ");

            string ime = Console.ReadLine();

            Console.WriteLine("Unio sam \n{0}\n{1}\n{2}\n{3}",
                i,LogickaVrijednost,broj,ime);



        }


    }
}

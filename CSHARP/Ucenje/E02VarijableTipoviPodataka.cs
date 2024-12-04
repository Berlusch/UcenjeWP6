
namespace Ucenje
{
    internal class E02VarijableTipoviPodataka
    {

        public static void Izvedi()
        {

            //Console.WriteLine("Hello E02");

            //integer cijeli broj

            //deklaracija varijable
            int i; //i je od increment

            Console.Write("Upiši broj: ");
            //dodijeljivanje vrijednosti
            // i = Console.ReadLine  Ovo ne radi jer je desno string, a lijevo int

            i = int.Parse(Console.ReadLine());

            //korištenje vrijednosti
            Console.WriteLine("Upisali ste {0}", i);



            //bit - logička vrijednost

            bool LogickaVrijednost;

            Console.Write("Unesi True ili False: ");

            LogickaVrijednost = bool.Parse(Console.ReadLine());

            Console.WriteLine("Unijeli ste {0}", LogickaVrijednost);


            //float - decimalni broj

            Console.Write("Unesi broj (, za decimalni dio): ");

            Console.WriteLine(float.Parse(Console.ReadLine()));

            float broj = 3.14F; //f zato što je to float



            Console.Write("Unesi ime: ");
            string ime = Console.ReadLine();

            Console.WriteLine("Unio sam \n{0}\n{1}\n{2}\n{3}",
                i, LogickaVrijednost, broj, ime);



        }


    }
}

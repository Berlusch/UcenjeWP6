
namespace Ucenje


{
      

    //Program od korisnika unosi dva cijela broja
    //Program ispisuje u novim redovima
    //1. zbroj
    //2. razliku drugog i prvog
    //3. umnožak
    //4. zbroj kvadrata prvog i drugog broja
    //5. kvocijent prvog i drugog broja
    internal class E03Z1
    {

        public static void Izvedi()
    {
        Console.Write("Unesi jedan cijeli broj: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Unesi drugi cijeli broj: ");
        int b = int.Parse(Console.ReadLine());

         //1
         Console.WriteLine("Zbroj ova dva broja je {0}", a + b);
         
         //2
         Console.WriteLine("Razlika drugog i prvog broja je {0}", b - a);

         //3
         Console.WriteLine("Umnožak ova dva broja je {0}", a * b);

         //4
         Console.WriteLine("Zbroj kvadrata ova dva broja je {0}", a * a + b * b);

         //5
         Console.WriteLine("Kvocijent prvog i drugog broja je {0}", a / b + ", s ostatkom " + a%b + ".");


    }
}
}

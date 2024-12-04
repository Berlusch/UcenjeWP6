
namespace Ucenje
{
    internal class E03Operatori
    {

        public static void Izvedi()

        {

            //Console.WriteLine("E03");
            //operatori za rad s varijablama
            // = je dodjeljivanje vrijednosti
            // == provjera vrijednosti

            int i = 7; //sada zamislimo da je korisnik unio 7
            Console.WriteLine(i == 6);

            //operatori +, -, *, /

            int k = 2, l = 1;
            Console.WriteLine(l / k); //dijeljenje dva int daje int

            // mehanizam cast -> interpretacija broja u drugom tipu podatka
            Console.WriteLine(l / (float)k);

            // != nije jednako

            Console.WriteLine(i != k);

            //operator modulo %

            Console.WriteLine("5%2={0}", 5%2);

            Console.WriteLine("4%2={0}", 4 % 2);

            //automatsko formatiranje ctrl K D

            //uvećavanje za 1
            int b = 0;

            //uvećaj za 1
            b = b + 1;

            //kraće
            b += 1;

            //najkraće
            b++;

            Console.WriteLine(b);


            //increment i decrement (i++ i i--)

            b = 0;
            //b++ prvo koristi pa uveća
            Console.WriteLine(b++);

            //++b prvo uveća pa koristi
            Console.WriteLine(++b);

            //isto vrijedi i za b-- te --b

            int t = 0, c = 1;
            t = c++ + t;//t = 1, c=2
            c += --t; //t=0, c=2
            Console.WriteLine(c+t);//2
        }


    }

}

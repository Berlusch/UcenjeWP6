namespace Ucenje
{
    internal class E03Operatori
    {

        public static void Izvedi()
        {

            //Console.WriteLine("E03");
            // operatori za rad s varijablama
            // = je dodjeljivanje vrijednost
            // == provjera jednakosti -> bool

            int i = 7; // sada zamislimo da je korisnik unio 7

            Console.WriteLine(i == 6);

            // operatori +, -, *, /

            int k = 2, l = 1;

            Console.WriteLine(l / k); // djeljenje dva int daje int

            // mehanizam cast -> interpretacija broja u drugom tipu podatka
            Console.WriteLine(l / (float)k);

            // != nije jednako

            Console.WriteLine(i != k);

            // operator modulo %

            Console.WriteLine("5%2={0}", 5 % 2);

            Console.WriteLine("4%2={0}", 4 % 2);

            // AUTOMATSKO FORMATIRANJE CTRL + K + D

            // uvećavanje za 1

            int b = 0;

            // uvećaj za 1
            b = b + 1; //1

            // kraće
            b += 1; //2

            //najkraće
            b++; //3

            // gornja tri primjera vrijede i za -, prva dva gornja vrijede i za * i /

            Console.WriteLine(b);

            // increment i decrement (i++ i i--)

            b = 0;

            // b++ prvo koristi pa uveća
            Console.WriteLine(b++); //0

            // ++b prvo uveća pa koristi
            Console.WriteLine(++b); //2

            // isto vrijedi i za b-- te --b

            int t = 0, c = 1;
            t = c++ + t; // t = 1, c = 2
            c += --t; // c = 2, t = 0
            Console.WriteLine(c+t); // 2














        }


    }
}

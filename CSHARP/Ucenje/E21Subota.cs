using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    class E21Subota
    {
        public E21Subota()
        {
            //Console.WriteLine("Hello from E21Subota");

           // SlucajniBrojevi();
            Ljubav();
        }

        private void Ljubav()
        {
            var ona = "Marta";
            var on = "Manuel";

            var izraz = ona.Trim().ToLower() + on.Trim().ToLower();

            Console.WriteLine(izraz);
            var brojevi = PrebrojiZnakove(izraz);

            Console.WriteLine(string.Join('|',izraz.ToArray()));
            Console.WriteLine(string.Join('|',brojevi));


        }

        private int[] PrebrojiZnakove(string izraz)
        {
            int[] brojevi = new int[izraz.Length];
            var ponovilose = 0;
            for (int i = 0; i < izraz.Length; i++)
            {
                ponovilose = 0;
                for (int j = 0; j < izraz.Length; j++)
                {
                    if (izraz[i] == izraz[j])
                    {
                        ponovilose++;
                    }
                }
                brojevi[i] = ponovilose;

            }
            return brojevi;
        }

        private void SlucajniBrojevi()
        {
            var rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(rnd.Next(20, 31));
            }
        }

    }
}

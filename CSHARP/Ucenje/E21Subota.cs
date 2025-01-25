using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E21Subota
    {
        public E21Subota()
        {
            Console.WriteLine("E21Subota");
            //SlucajniBrojevi();
            //SlucajniDatumi();
            Ljubav();
        }

        private void Ljubav()
        {
            var ona = "Marta";
            var on = "Manuel";

            var izraz = ona.Trim().ToLower() + on.Trim().ToLower();
            Console.WriteLine(izraz);

            int[] brojevi = new int[izraz.Length];
            var ponovilose = 0;
            for (int i= 0; i < izraz.Length; i++)
            {
                ponovilose = 0;
                for (int j = 0; i  < izraz.Length; i++)
                {
                    if (izraz[i] == izraz[j])
                    {
                        ponovilose++;
                    }
                    brojevi[i] = ponovilose;
                }
                
            }
            Console.WriteLine(string.Join("|",izraz));
            Console.WriteLine(string.Join("|", ponovilose));
        }

        private static void SlucajniBrojevi()
        {
            var random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next(20,31));
            }

        }
        private static void SlucajniDatumi()
        {
            var random = new Random();
            for (int i = 0; i < 100; i++)
            {
                try
                {
                    var d = new DateTime(2023, random.Next(1, 13), random.Next(1, 32));
                    Console.WriteLine((i+1)+": "+d.ToString("yyyy-MM-dd"));
                }
                catch
                {
                    i--;

                }
                
            }

        }
    }
}

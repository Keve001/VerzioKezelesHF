using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerzioKezelesHF
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int szam = 0;
            Console.WriteLine("Adja meg hány számot akar:");
            N = Convert.ToInt32(Console.ReadLine());
            int[] t = new int[N];
            do
            {
                
                Console.WriteLine("Adja meg a számot!");
                t[szam] = Convert.ToInt32(Console.ReadLine());
                szam++;

            } while (szam !=N);
            int atlagSzam = 0;
            for (int i = 0; i < t.Length; i++)
            {
                atlagSzam += t[i];
            }
            Console.WriteLine("Atlag:{0}",atlagSzam/t.Length);

            Console.ReadLine();
        }
    }
}

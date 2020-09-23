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
            int szam = 0;
            int[] t = new int[5];
            do
            {
                Console.WriteLine("Adja meg a számot!");
                t[szam] = Convert.ToInt32(Console.ReadLine());
                szam++;

            } while (szam !=5);
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

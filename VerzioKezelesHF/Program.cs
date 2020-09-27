using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Runtime.InteropServices;
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
            //List<int> t = new List<int>();
            int[] t = new int[N];
            do
            {

                Console.WriteLine("Adja meg a számot!");
                t[szam] = Convert.ToInt32(Console.ReadLine());
		        szam++;

            } while (szam != N);

            int atlagSzam = 0;
            for (int i = 0; i < t.Length; i++)
            {
               atlagSzam += t[i];
            }
            Console.WriteLine("Atlag:{0}", atlagSzam / t.Length);
            int max = t[0];
            for (int p = 0; p < t.Length; p++)
            {
                if (t[p] > max)
                {
                    max = t[p];
                }
            }
            Console.WriteLine("Max: " + max);
            int min = t[0];
            for (int ps = 0; ps < t.Length; ps++)
            {
                if (t[ps] < min)
                {
                    min = t[ps];
                }
            }
            Console.WriteLine("Min: " + min);



            Console.ReadLine();

        }
    }
}







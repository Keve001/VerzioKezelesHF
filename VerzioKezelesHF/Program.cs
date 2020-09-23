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
            int[] t = new int[10];
            do
            {
                Console.WriteLine("Adja meg a számot!");
                int sajat = Convert.ToInt32(Console.ReadLine());
                szam++;

            } while (szam !=10);
        }
    }
}

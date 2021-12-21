using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema58
{
    class Problema58
    {
        static void Main(string[] args)
        {
            int n, k;
            Console.WriteLine("Se citesc de la tastatură k, un număr întreg, n<=1000, un număr natural si n numere întregi.");
            k = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
            bool afisat = false;
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            for (int i = n - 1; i >= 0; i--)
            {
                if (v[i] == k)
                {
                    Console.WriteLine("Pozitia numarului {0} este {1}",k, i);
                    afisat = true;
                    break;

                }
            }
            if(!afisat)
                Console.WriteLine("Numarul {0} nu exista in vector",k);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema60
{
    class Problema60
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Se citesc de la tastatură k, un număr întreg, n<=1000, un număr natural");
            int n, k;
            k = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];

            Console.WriteLine("Dati n numere intregi: ");
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (v[i] == k)
                {
                    for (int j = i; j < n - 1; j++)
                    {
                        v[j] = v[j + 1];
                        if (j + 1 == n)
                            v[j + 1] = 0;
                    }
                    n--;

                }
            }
            Console.WriteLine("Vectorul dupa eliminari este: ");
            for(int i=0;i<n;i++)
            {
                Console.Write($" {v[i]} ");
            }
        }
    }
}

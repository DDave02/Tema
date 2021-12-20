using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema31
{
    class Problema31
    {
        static void Main(string[] args)
        {
            //Problema 26 dar in loc de Console.Write le pun intr-un vector si nu le afisez (generare)
            Console.WriteLine("Dati un nr natural. ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int j = 0;
            for (int i = 3; i <= n; i++)
            {
                if (prime(i))
                {
                    v[j] = i;
                    j++;
                }
            }
        }

            private static bool prime(int k)
            {
                for (int d = 2; d <= k / 2 + 1; d++)
                {
                    if (k % d == 0)
                        return false;
                }
                return true;
        }
    }
}

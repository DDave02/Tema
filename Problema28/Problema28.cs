using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema28
{
    class Problema28
    {
        static void Main(string[] args)
        {
            int i,x=999;
            for(i=100;i<=x;i++)
            {
                if(prime(i))
                    if(prime(invers(i)))
                        Console.WriteLine($"Numarul {i} este prim dar si inversa lui este prim.");
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

        private static int invers(int k)
        {
            int inv=0;
            while (k != 0)
            {
                inv = k % 10 + inv * 10;
                k /= 10;
            }
            return inv;
        }
    }
}

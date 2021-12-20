using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema27
{
    class Problema27
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dati un numar natural n: ");
            int n= int.Parse(Console.ReadLine());
            Console.WriteLine("Si suma unor cifre m: ");
            int m= int.Parse(Console.ReadLine());
            Console.Write($"Numerele prime pana la {n} cu suma cifrelor {m} sunt: ");
            int x;
            int z;
            for(int i=1;i<=n;i++)
            {
                if (prime(i))
                {
                    x = i;
                    z = 0;
                    while (x!=0)
                    {
                        
                        z = z + x % 10;
                        x /= 10;
                        if (x == 0)
                        {
                            if (z == m)
                                Console.Write($"{i} ");
                            else
                                break;
                            break;
                        }
                        else
                            continue;
                    }
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

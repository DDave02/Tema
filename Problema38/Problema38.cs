using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema38
{
    class Problema38
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Dati un numar natural n mai mare sau egal cu 0. ");
            n = int.Parse(Console.ReadLine());
            Factorial(n);
        }

        private static void Factorial(int n)
        {
            int f = 1;
            while (n < 0)
            {
                Console.WriteLine("Numarul este mai mic decat 0, dati un numar mai mare sau egal decat 0");
                n = int.Parse(Console.ReadLine());
            }                   
            for(int i=1;i<=n;i++)
            {
                f *= i;
            }
            Console.WriteLine($"n!={f}");
        }
    }
}

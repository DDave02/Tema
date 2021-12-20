using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema15
{
    class Problema15
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dati un numar n");
            int n, nf = 1;
            n = int.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++)
                nf *= i;
            Console.WriteLine($"Factorialul lui {n} este {nf}.");
        }
    }
}

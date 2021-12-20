using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema22
{
    class Problema22
    {
        static void Main(string[] args)
        {
            int n, k,p=0;
            Console.WriteLine("Dati cele 2 numere: ");
            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            for (int i = 0; i < k; i++)
                p += n;
            Console.WriteLine($"Produsul a celor doua numere este {p}.");
        }
    }
}

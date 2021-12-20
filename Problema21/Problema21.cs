using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema21
{
    class Problema21
    {
        static void Main(string[] args)
        {
            int n, p, k;
            Console.WriteLine("Dati cele trei numere n, p si k.");
            n = int.Parse(Console.ReadLine());
            p = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati sirul de n numere: ");
            int[] v = new int[n];
            int counter = 0;
            for(int i = 0;i<n;i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                if (v[i] % p == k)
                    counter++;
            }
            Console.WriteLine($"Exista {counter} numar/numere in sir impartite la {p} cu restul {k}.");
        }
    }
}

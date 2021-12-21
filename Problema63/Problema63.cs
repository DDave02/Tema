using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema63
{
    class Problema63
    {
        static void Main(string[] args)
        {
            int n, k,con=0;
            Console.WriteLine("Dati numerele n si k: ");
            Console.Write("n="); n = int.Parse(Console.ReadLine());
            Console.Write("k="); k = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int[] ui = new int[n];
            Console.WriteLine("Dati sirul de numere: ");
            for (int i = 0; i < n; i++)
            {
                v[i]=int.Parse(Console.ReadLine());
                if(v[i]%10==k)
                {
                    ui[con] = v[i];
                    con++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Vectorul initial este: ");
            for(int i=0;i<n;i++)
            {
                Console.Write($" {v[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine("Vectorul cu elementele cu ultima cifra k");
            for (int i = 0; i < con; i++)
            {
                Console.Write($" {ui[i]} ");
            }
        }
    }
}

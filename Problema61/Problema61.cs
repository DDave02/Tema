using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema61
{
    class Problema61
    {
        static void Main(string[] args)
        {
            int x, k, n;
            Console.WriteLine("un număr întreg x, k<=n<=1000, două numere naturale");
            Console.Write("x="); x = int.Parse(Console.ReadLine());
            Console.Write("k="); k = int.Parse(Console.ReadLine());
            Console.Write("n="); n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("Dati n numere intregi: ");
            for(int i=0;i<n;i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            Array.Resize(ref v, n + 1);
            n++;
            for(int i=n-2;i>=1;i--)
            {
                v[i] = v[i-1];
                if(i==k)
                {
                    v[i - 1] = v[i];
                    v[i] = x;
                }
            }
            for(int i=0;i<n;i++)
                Console.Write($" {v[i]} ");
        }
    }
}

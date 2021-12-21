using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema64
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, con=0;
            Console.WriteLine("Dati nr n: ");
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int[] parImp = new int[n];
            Console.WriteLine("Dati n numere intregi: ");
            for(int i=0;i<n;i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                if(v[i]%2==0)
                {
                    parImp[con] = v[i];
                    con++;
                }
            }
            for (int i = 0; i < n; i++)
            {
                if(v[i]%2==1)
                {
                    parImp[con] = v[i];
                    con++;
                }
            }
            Console.WriteLine("Vectorul ordonat par/impar este: ");
            for (int i = 0; i < con; i++)
            {
                Console.Write($" {parImp[i]} ");
            }
        }
    }
}

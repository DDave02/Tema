using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema45
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dati numarul de elemente dintr-un tablou");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine("Scrieti elementele unui tablou pe randuri diferite: ");
            int[] v = new int[n];
            for(int i=0;i<n;i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Elementele tabloutului sunt: ");
            for(int i=0;i<n;i++)
            {
                Console.Write($" {v[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine("Inversatul elementelor tabloului sunt: ");
            for(int i=0;i<n;i++)
            {
                Console.Write($" {invers(v[i])} ");
            }
            Console.WriteLine();
        }

        private static int invers(int v)
        {
            int inv = 0;
            while(v!=0)
            {
                inv = inv*10 + v % 10;
                v /= 10;
            }
            return inv;
        }
    }
}

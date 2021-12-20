using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema49
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[21];
            Random rnd = new Random();
            for(int i=0;i<21;i++)
            {
                v[i] = rnd.Next(500);
            }
            Console.WriteLine("Vectorul este: ");
            for (int i = 0; i < 21; i++)
            {
                Console.Write($" {v[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Media aritmetica elementelor pare dintr-un vector este: {medAritmPar(v) }");
        }

        private static object medAritmPar(int[] v)
        {
            int s = 0, c = 0;
            for(int i = 0;i<21;i++)
            {
                if(v[i]%2==0)
                {
                    c++;
                    s += v[i];
                }
            }
            return s / c;
        }
    }
}

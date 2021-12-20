using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema5
{
    class Problema5
    {
        static void Main(string[] args)
        {
            int a, b,x=0;
            Console.WriteLine("Introduceti capetele intervalului.");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            int[] v = new int[b - a];
            for (int i=a; i<=b;i++)
            {
                if(numarPerfect(i)==true)
                {
                    x++;
                    v[x] = i;
                }
            }
            if (x!=0)
            {
                Console.Write($"Numerele perfecte din intervalul [{a},{b}]: ");
                for (int i = 1; i <= x; i++)
                {
                    Console.Write($"{v[i]} ");
                }
                Console.WriteLine(".");
            }
            else
                Console.WriteLine("Nu exista numare perfecte in interval");
        }

        private static bool numarPerfect(int i)
        {
            int suma = 0;
            if (i == 0)
                return false;
            for (int j = 1; j <= i / 2; j++)
            {
                if (i % j == 0)
                    suma += j;
            }
            if (suma == i)
                return true;
            return false;
        }
    }
}

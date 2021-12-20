using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema48
{
    class Problema48
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dati marimea matricelor: (marimea este n*n) ");
            int n = int.Parse(Console.ReadLine());
            int[,] a1 = new int[n,n];
            int[,] a2 = new int[n,n];
            int[,] a3 = new int[n, n];
            Random rnd = new Random();
            for(int i=0;i<n;i++)
            {
                for (int j = 0; j < n; j++)
                    a1[i, j] = rnd.Next(500);
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    a2[i, j] = rnd.Next(500);
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    a3[i, j] = a1[i, j] + a2[i, j];
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write($" {a1[i,j]} ");
                Console.WriteLine();
            }
            Console.WriteLine("+");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write($" {a2[i, j]} ");
                Console.WriteLine();
            }
            Console.WriteLine("=");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write($" {a3[i, j]} ");
                Console.WriteLine();
            }
        }
    }
}

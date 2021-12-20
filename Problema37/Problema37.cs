using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema37
{
    class Problema37
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Dati un numar n: ");
            n = int.Parse(Console.ReadLine());
            Fibonacci(n);
        }

        private static void Fibonacci(int n)
        {
            int fk1 = 1, fk2 = 1, fk3, counter=2;
            if(n<2)
            {
                Console.WriteLine("Primul element este: 1.");
            }
            if(n==2)
            {
                Console.WriteLine("Primele doua elemente sunt: 1,1.");
            }    
            if(n<0)
            {
                Console.WriteLine("Nu se pot afisa elemente negative.");
            }
            if(n>2)
            {
                Console.Write("Primele {0} elemente sunt: 1, 1,",n);
                while(counter<n)
                {
                    fk3 = fk2 + fk1;
                    fk1 = fk2;
                    fk2 = fk3;
                    counter++;
                    Console.Write($" {fk3}, ");
                }
            }

        }
    }
}

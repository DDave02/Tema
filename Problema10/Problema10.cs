using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema10
{
    class Problema10
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Dati un numar n.");
            n = int.Parse(Console.ReadLine());
            int k = 2,count=1;
            Console.Write("Primele n numere prime sunt: 2");
            while(true)
            {
                if(prime(k))
                {
                    Console.Write($",{k}");
                    count++;
                }
                k++;
                if (count == n)
                    break;
            }
            Console.WriteLine(".");
        }

        private static bool prime(int k)
        {
            for(int d=2;d<=k/2+1;d++)
            {
                if (k % d == 0)
                    return false;
            }
            return true;
        }
    }
}

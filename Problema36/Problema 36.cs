using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema36
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dati un numar natural x: ");
            int x=int.Parse(Console.ReadLine());
            inv(x);
        }

        private static void inv(int x)
        {
            int nrcif = 0;
            Console.Write("Cifrele numarului {0} in ordine inversa sunt: ",x);
            while(x!=0)
            {
                Console.Write($"{x%10} ");
                nrcif++;
                x /= 10;
            }
            Console.WriteLine($"Numarul de cifre este: {nrcif}. ");
        }
    }
}

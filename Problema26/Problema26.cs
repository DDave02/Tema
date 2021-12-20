using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema26
{
    class Problema26
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dati un nr natural. ");
            int m = int.Parse(Console.ReadLine());
            Console.Write($"Numerele prime pana la {m} sunt: 2");
            for(int i=3;i<=m;i++)
            {
                if(prime(i))
                    Console.Write($", {i}");
            }
            Console.WriteLine(".");
        }

        private static bool prime(int k)
        {
            for (int d = 2; d <= k / 2 + 1; d++)
            {
                if (k % d == 0)
                    return false;
            }
            return true;
        }
    }
}

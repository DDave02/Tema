using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema42
{
    class Problema42
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dati un numar natural.");
            int n = int.Parse(Console.ReadLine());
            if(cub(n))
            {
                Console.WriteLine("Numarul este cub perfect.");
            }    
            else
                Console.WriteLine("Numarul nu este cub perfect.");
        }

        private static bool cub(int n)
        {
            for(int i=1;i*i*i<=n;i++)
            {
                if (i * i * i == n)
                    return true;
            }
            return false;
        }
    }
}

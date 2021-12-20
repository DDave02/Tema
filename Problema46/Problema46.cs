using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema46
{
    class Problema46
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Dati un numar natural n: ");
            n = int.Parse(Console.ReadLine());
            if(palindrom(n))
            {
                Console.WriteLine("Numarul dat este palindrom.");
            }    
            else
                Console.WriteLine("Numarul dat nu este palindrom.");
        }

        private static bool palindrom(int n)
        {
            int inv=0, x=n;
            while(x!=0)
            {
                inv = inv * 10 + x % 10;
                x /= 10;
            }
            if (n == inv)
                return true;
            return false;
        }
    }
}

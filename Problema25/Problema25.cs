using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema25
{
    class Problema25
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dati un nr natural.");
            int c = int.Parse(Console.ReadLine());
            int inv = 0, z = c;
            while(z!=0)
            {
                inv = z % 10 + inv * 10;
                z /= 10;
            }
            if(inv==c)
                Console.WriteLine("Numarul este palindrom");
            else
                Console.WriteLine("Numarul nu este palindrom");
        }
    }
}

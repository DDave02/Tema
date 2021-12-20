using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema24
{
    class Problema24
    {
        static void Main(string[] args)
        {
            int c;
            Console.WriteLine("Dati un nr natural.");
            c= int.Parse(Console.ReadLine());
            int z = 0;
            while(c!=0)
            {
                c /= 10;
                z++;
            }
            Console.WriteLine($"Numarul are {z} cifre.");
        }
    }
}

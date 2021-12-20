using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema29
{
    class Problema29
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dati un numar natural n: ");
            int n= int.Parse(Console.ReadLine()), scif,z;
            for (int i = 1; i <= n; i++)
            {
                scif = 0;
                z = i;
                while(z!=0)
                {
                    scif += z % 10;
                    z /= 10;
                }
                if(scif%5==0)
                    Console.WriteLine($"Numarul {i} are suma cifrelor divizibila cu 5. ");
                
            }
        }
    }
}

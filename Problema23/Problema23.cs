using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema23
{
    class Problema23
    {
        static void Main(string[] args)
        {
            int n, k,r=0,c=0;
            Console.WriteLine("Dati cele 2 nr. ");
            n= int.Parse(Console.ReadLine());
            k= int.Parse(Console.ReadLine()); 
            while (n>0)
            {
                if (n - k < 0)
                {
                    r = n;
                    break;
                }
                n -= k;
                c++;

            }
            Console.WriteLine($"Catul impartirii este {c} si restul este {r}.");
        }
    }
}

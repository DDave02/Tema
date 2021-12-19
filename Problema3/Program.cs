using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema3
{
    class Program
    {
        static void Main(string[] args)
        {
            double i, j, k,p=1;
            Console.WriteLine("Introduceti cele 3 numere pe randuri separate: ");
            i = double.Parse(Console.ReadLine());
            j = double.Parse(Console.ReadLine());
            k = double.Parse(Console.ReadLine());
            for (int d = 0; d < j; d++)
            {
                p = p * i;
            }
            Console.WriteLine("Restul impartirii este: "+(p%k));

        }
    }
}
